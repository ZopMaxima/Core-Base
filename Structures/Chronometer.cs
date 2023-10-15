// Chronometer.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   December 7, 2016

using System;
using System.Diagnostics;

namespace Zop
{
	/// <summary>
	/// A semi-plagiarized Stopwatch used to self-correct abrupt changes in the performance counter by watching environment ticks in parallel.
	/// </summary>
	public class Chronometer
	{
		// ////////////////////////////////////////////////////////////////////////// //
		/* ************************************************************************** */
		// ATTRIBUTES
		/* ************************************************************************** */
		// ////////////////////////////////////////////////////////////////////////// //

		#region Attributes

		// ////////////////////////////////// //
		/* ********************************** */
		// CONSTANT ATTRIBUTES
		/* ********************************** */
		// ////////////////////////////////// //

		/// <summary>
		/// This watch will accept gradual change: Drift the environment counter toward the performance counter when the difference exceeds this time.
		/// </summary>
		private const long ENV_DRIFT = TimeSpan.TicksPerSecond;

		/// <summary>
		/// This watch will reject sudden change: Snap the performance counter back to the environment counter when the difference exceeds this time.
		/// </summary>
		private const long QPC_SNAP = 2 * ENV_DRIFT;

		// ////////////////////////////////// //
		/* ********************************** */
		// PUBLIC ATTRIBUTES
		/* ********************************** */
		// ////////////////////////////////// //

		public static long Frequency { get { return Stopwatch.Frequency; } }
		public static bool IsHighResolution { get { return Stopwatch.IsHighResolution; } }

		/// <summary>
		/// Whether or not this Chronometer has been started and is currently running.
		/// </summary>
		public bool IsRunning { get { return _isRunning; } }

		/// <summary>
		/// Returns TimeSpan ticks (100ns).
		/// </summary>
		public long ElapsedTicks { get { return (Stopwatch.IsHighResolution) ? (unchecked((long)(ElapsedQPCTicks * _qpcToTimeSpan))) : (ElapsedQPCTicks); } }

		/// <summary>
		/// Returns Environment ticks (1ms).
		/// </summary>
		public long ElapsedEnvTicks { get { lock (_lock) { Elapse(); return _elapsedEnv; } } }

		/// <summary>
		/// Returns QueryPerformanceCounter ticks (variable).
		/// </summary>
		public long ElapsedQPCTicks { get { lock (_lock) { Elapse(); return _elapsedQPC + _cacheQPC; } } } // NOTE: _cacheQPC is set during Elapse().

		// ////////////////////////////////// //
		/* ********************************** */
		// PRIVATE ATTRIBUTES
		/* ********************************** */
		// ////////////////////////////////// //

		private readonly object _lock = new object();

		private static double _ticksToMillis = 1.0d / TimeSpan.TicksPerMillisecond; // NOTE: A cached double, so that I don't have to cast my math twice.
		private static double _qpcToTimeSpan = 1.0d;
		private static long _frequency = TimeSpan.TicksPerSecond; // NOTE: Some people say it changes, Microsoft says it doesn't, Unity broke this number and always returns a constant...

		private int _ticksEnv;
		private long _elapsedEnv;

		private long _startQPC;
		private long _cacheQPC;
		private long _elapsedQPC;

		private bool _isRunning;

		#endregion

		// ////////////////////////////////////////////////////////////////////////// //
		/* ************************************************************************** */
		// CONSTRUCTORS
		/* ************************************************************************** */
		// ////////////////////////////////////////////////////////////////////////// //

		#region Constructors

		/// <summary>
		/// Calculate a QPC-to-TimeSpan tick.
		/// </summary>
		static Chronometer()
		{
			if (Stopwatch.IsHighResolution)
			{
				_frequency = Stopwatch.Frequency;
				_qpcToTimeSpan = TimeSpan.TicksPerSecond / _frequency;
			}
		}

		#endregion

		// ////////////////////////////////////////////////////////////////////////// //
		/* ************************************************************************** */
		// METHODS
		/* ************************************************************************** */
		// ////////////////////////////////////////////////////////////////////////// //

		#region Methods

		/// <summary>
		/// Start the timer.
		/// </summary>
		public void Start()
		{
			lock (_lock)
			{
				if (!_isRunning)
				{
					_ticksEnv = Environment.TickCount;
					_startQPC = Stopwatch.GetTimestamp();
					_isRunning = true;
				}
			}
		}

		/// <summary>
		/// Stop the timer.
		/// </summary>
		public void Stop()
		{
			lock (_lock)
			{
				if (_isRunning)
				{
					Elapse();
					_ticksEnv = 0;
					_elapsedQPC += _cacheQPC;
					_cacheQPC = 0;
					_isRunning = false;
				}
			}
		}

		/// <summary>
		/// Reset the timer.
		/// </summary>
		public void Reset()
		{
			lock (_lock)
			{
				_ticksEnv = 0;
				_elapsedEnv = 0;
				_elapsedQPC = 0;
				_startQPC = 0;
				_isRunning = false;
			}
		}

		/// <summary>
		/// Calculate the new elapsed time.
		/// </summary>
		private void Elapse()
		{
			// Update the environment ticks, they cannot be calculated because they wrap.
			if (_isRunning)
			{
				// Test frequency, because uLink suspects it.
				//if (_frequency != Stopwatch.Frequency)
				//{
				//	long previous = _frequency;
				//	_frequency = Stopwatch.Frequency;
				//	this.LogError("{0} has changed frequency from {1} to {2}.", GetType().Name, previous, _frequency);
				//}

				// Only get ticks once.
				int ticks = Environment.TickCount;

				// Assume that the environment jumps form int.Max to int.Min.
				if (ticks < _ticksEnv)
				{
					_elapsedEnv += int.MaxValue - _ticksEnv;
					_elapsedEnv += ticks - int.MinValue;
				}
				else
				{
					_elapsedEnv += ticks - _ticksEnv;
				}

				// Cache
				_ticksEnv = ticks;

				// NOTE: _cacheQPC is being set here for approval.
				_cacheQPC = Stopwatch.GetTimestamp() - _startQPC;
				long qpcTicks = (long)((_elapsedQPC + _cacheQPC) * _qpcToTimeSpan);
				long envTicks = _elapsedEnv * TimeSpan.TicksPerMillisecond;

				// Test the difference between counters.
				if (qpcTicks > envTicks)
				{
					// QPC is ahead of Environment.
					if (qpcTicks - envTicks > ENV_DRIFT)
					{
						long difference = qpcTicks - envTicks;
						if (difference > QPC_SNAP)
						{
							_elapsedQPC -= (long)(difference / _qpcToTimeSpan);
							// Debug.LogErrorFormat("{0} has snapped the performance counter backward by {1} ticks to match the environment.", GetType().Name, difference);
						}
						else
						{
							_elapsedEnv += (long)(difference * _ticksToMillis);
							// Debug.LogErrorFormat("{0} has drifted the environment forward by {1} ticks to match the performance counter.", GetType().Name, difference);
						}
					}
				}
				else
				{
					// Environment is ahead of QPC.
					if (envTicks - qpcTicks > ENV_DRIFT)
					{
						long difference = envTicks - qpcTicks;
						if (difference > QPC_SNAP)
						{
							_elapsedQPC += (long)(difference / _qpcToTimeSpan);
							// Debug.LogErrorFormat("{0} has snapped the performance counter forward by {1} ticks to match the environment.", GetType().Name, difference);
						}
						else
						{
							_elapsedEnv -= (long)(difference * _ticksToMillis);
							// Debug.LogErrorFormat("{0} has drifted the environment backward by {1} ticks to match the performance counter.", GetType().Name, difference);
						}
					}
				}
			}
		}

		#endregion
	}
}