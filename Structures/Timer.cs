// Timer.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   December 6, 2021

using System;

namespace Zop
{
	/// <summary>
	/// A synchronized timer for networking and in-game events.
	/// </summary>
	public class Timer
	{
		private const float MULTIPLIER_TICKS = 1.0f / TimeSpan.TicksPerSecond;

		public const string UNIDENTIFIED = "Unidentified";

		public string ID { get { return _id; } }
		public int SessionID { get { return _session; } }

		public double Offset { get { return _offset; } }

		public double ElapsedSession { get { return _offset + (_chronometer.ElapsedTicks * MULTIPLIER_TICKS); } }
		public double ElapsedTotal { get { return _loaded + _offset + (_chronometer.ElapsedTicks * MULTIPLIER_TICKS); } }

		private string _id;
		private Chronometer _chronometer;

		private int _session;
		private double _loaded;
		private double _offset;

		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Timer() : this(UNIDENTIFIED) { }

		/// <summary>
		/// Construct with an ID.
		/// </summary>
		public Timer(string id)
		{
			_id = id;
			_chronometer = new Chronometer();
		}

		/// <summary>
		/// Load the timer.
		/// </summary>
		public void Load(int session, double elapsed, double offset)
		{
			_session = session;
			_loaded = elapsed;
			_offset = offset;
		}

		/// <summary>
		/// Offset the timer.
		/// </summary>
		public void SetOffset(double time)
		{
			_offset = time;
		}

		/// <summary>
		/// Offset the timer.
		/// </summary>
		public void AddOffset(double time)
		{
			_offset += time;
		}

		/// <summary>
		/// Start the timer.
		/// </summary>
		public void Start()
		{
			_chronometer.Start();
		}

		/// <summary>
		/// Stop the timer.
		/// </summary>
		public void Stop()
		{
			_chronometer.Stop();
		}

		/// <summary>
		/// Reset the timer.
		/// </summary>
		public void Reset()
		{
			_chronometer.Reset();
		}

		/// <summary>
		/// Clear the timer.
		/// </summary>
		public void Clear()
		{
			_chronometer.Stop();
			_chronometer.Reset();
			_session = 0;
			_loaded = 0;
			_offset = 0;
		}
	}
}