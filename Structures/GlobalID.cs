// GlobalID.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 14, 2022

using System.Collections.Generic;

namespace Zop
{
	/// <summary>
	/// Allow an object of any type to be referenced by ID.
	/// </summary>
	public static class GlobalID<T> where T : class
	{
		public const ulong UNASSIGNED = 0;

		public static int Count { get { return _ids.Count; } }
		public static ulong MinID { get { return _min; } }
		public static ulong MaxID { get { return _max; } }

		public static readonly IReadOnlyDictionary<ulong, T> All;
		private static readonly Dictionary<T, ulong> _instances = new Dictionary<T, ulong>(ObjectComparer.Instance);
		private static readonly Dictionary<ulong, T> _ids = new Dictionary<ulong, T>();
		
		private static ulong _min;
		private static ulong _max;

		/// <summary>
		/// Initialize.
		/// </summary>
		static GlobalID()
		{
			All = _ids;
		}

		/// <summary>
		/// Returns true if the lookup contains this ID.
		/// </summary>
		public static bool Has(ulong id)
		{
			return _ids.ContainsKey(id);
		}

		/// <summary>
		/// Returns true if the lookup contains this instance.
		/// </summary>
		public static bool Has(T instance)
		{
			return instance != null && _instances.ContainsKey(instance);
		}

		/// <summary>
		/// Returns the instance of this ID.
		/// </summary>
		public static T Get(ulong id)
		{
			return (_ids.TryGetValue(id, out T instance)) ? (instance) : (null);
		}

		/// <summary>
		/// Returns the ID of this instance.
		/// </summary>
		public static ulong Get(T instance)
		{
			return (instance != null && _instances.TryGetValue(instance, out ulong id)) ? (id) : (UNASSIGNED);
		}

		/// <summary>
		/// Set an instance by ID.
		/// </summary>
		public static void Set(ulong id, T instance)
		{
			if (id != UNASSIGNED && !((object)instance == null))
			{
				// Cache
				if (Count == 0)
				{
					_min = id;
					_max = id;
				}
				if (id < _min)
				{
					_min = id;
				}
				if (id > _max)
				{
					_max = id;
				}

				// Remove current lookups.
				if (_instances.TryGetValue(instance, out ulong currentID))
				{
					_ids.Remove(currentID);
				}
				if (_ids.TryGetValue(id, out T currentInstance))
				{
					_instances.Remove(currentInstance);
				}

				// Apply
				_instances[instance] = id;
				_ids[id] = instance;
			}
		}

		/// <summary>
		/// Returns an ID for a new instance.
		/// </summary>
		public static ulong Add(T instance)
		{
			ulong result;

			// Check instance.
			if (!_instances.TryGetValue(instance, out result))
			{
				// Cache
				if (Count == 0)
				{
					result = 1;
					_min = 1;
					_max = 1;
				}
				else
				{
					_max++;
					result = _max;
				}
			}

			// Apply
			_instances[instance] = result;
			_ids[result] = instance;

			// Return
			return result;
		}

		/// <summary>
		/// Remove an instance by ID.
		/// </summary>
		public static void Remove(ulong id)
		{
			T instance = Get(id);
			if (!((object)instance == null))
			{
				_instances.Remove(instance);
			}
			_ids.Remove(id);
		}

		/// <summary>
		/// Remove an instance by ID.
		/// </summary>
		public static void Remove(T instance)
		{
			if (!((object)instance == null))
			{
				_ids.Remove(Get(instance));
				_instances.Remove(instance);
			}
		}

		/// <summary>
		/// Clear the lookup.
		/// </summary>
		public static void Clear()
		{
			_instances.Clear();
			_ids.Clear();
			_min = UNASSIGNED;
			_max = UNASSIGNED;
		}
	}
}