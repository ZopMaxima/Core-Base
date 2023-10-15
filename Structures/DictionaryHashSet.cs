// DictionaryHashSet.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 22, 2022

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Zop
{
	/// <summary>
	/// Automatically create and destroy an internal hash set per key.
	/// </summary>
	public class DictionaryHashSet<TSuperKey, TSubKey> : IEnumerable<KeyValuePair<TSuperKey, HashSet<TSubKey>>>
	{
		public readonly ReadOnlyDictionary<TSuperKey, HashSet<TSubKey>> Data;
		public IEqualityComparer<TSuperKey> SuperKeyComparer { get { return _superKeyComparer; } }
		public IEqualityComparer<TSubKey> SubKeyComparer { get { return _subKeyComparer; } }

		private readonly Dictionary<TSuperKey, HashSet<TSubKey>> _data;
		private IEqualityComparer<TSuperKey> _superKeyComparer;
		private IEqualityComparer<TSubKey> _subKeyComparer;
		private bool _canSuperCompare;
		private bool _canSubCompare;
		private bool _canSuperNull;
		private bool _canSubNull;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DictionaryHashSet() : this(null, null) { }

		/// <summary>
		/// Construct with a superkey comparer.
		/// </summary>
		public DictionaryHashSet(IEqualityComparer<TSuperKey> superKeyComparer) : this(superKeyComparer, null) { }

		/// <summary>
		/// Construct with key comparers.
		/// </summary>
		public DictionaryHashSet(IEqualityComparer<TSuperKey> superKeyComparer, IEqualityComparer<TSubKey> subKeyComparer)
		{
			if (superKeyComparer != null)
			{
				_data = new Dictionary<TSuperKey, HashSet<TSubKey>>(superKeyComparer);
			}
			else
			{
				_data = new Dictionary<TSuperKey, HashSet<TSubKey>>();
			}
			Data = new ReadOnlyDictionary<TSuperKey, HashSet<TSubKey>>(_data);
			_superKeyComparer = superKeyComparer;
			_subKeyComparer = subKeyComparer;
			_canSuperCompare = superKeyComparer != null;
			_canSubCompare = subKeyComparer != null;
			_canSuperNull = default(TSuperKey) == null;
			_canSubNull = default(TSubKey) == null;
		}

		/// <summary>
		/// Returns true if this subset exists.
		/// </summary>
		public bool Has(TSuperKey superKey)
		{
			return _data.ContainsKey(superKey);
		}

		/// <summary>
		/// Returns true if this value exists.
		/// </summary>
		public bool Has(TSuperKey superKey, TSubKey subKey)
		{
			return _data.TryGetValue(superKey, out HashSet<TSubKey> subData) && subData.Contains(subKey);
		}

		/// <summary>
		/// Add a value.
		/// </summary>
		public bool Add(TSuperKey superKey, TSubKey subKey)
		{
			// Null checks.
			if (_canSuperNull && (_canSuperCompare ? _superKeyComparer.Equals(superKey, default) : superKey == null))
			{
				return false;
			}
			if (_canSubNull && (_canSuperCompare ? _subKeyComparer.Equals(subKey, default) : subKey == null))
			{
				return false;
			}

			// Search
			HashSet<TSubKey> subData;
			if (!_data.TryGetValue(superKey, out subData))
			{
				subData = (_canSubCompare) ? (new HashSet<TSubKey>(_subKeyComparer)) : (new HashSet<TSubKey>());
				_data.Add(superKey, subData);
			}

			// Add
			return subData.Add(subKey);
		}

		/// <summary>
		/// Remove a subset.
		/// </summary>
		public bool Remove(TSuperKey superKey)
		{
			return _data.Remove(superKey);
		}

		/// <summary>
		/// Remove a value.
		/// </summary>
		public bool Remove(TSuperKey superKey, TSubKey subKey)
		{
			bool result = false;

			// Search
			HashSet<TSubKey> subData;
			if (_data.TryGetValue(superKey, out subData))
			{
				result = subData.Remove(subKey);
				if (result && subData.Count == 0)
				{
					_data.Remove(superKey);
				}
			}

			// Return
			return result;
		}

		/// <summary>
		/// Clear all data.
		/// </summary>
		public void Clear()
		{
			_data.Clear();
		}

		/// <summary>
		/// Return an enumerator for looping.
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return _data.GetEnumerator();
		}

		/// <summary>
		/// Return an enumerator for looping.
		/// </summary>
		IEnumerator<KeyValuePair<TSuperKey, HashSet<TSubKey>>> IEnumerable<KeyValuePair<TSuperKey, HashSet<TSubKey>>>.GetEnumerator()
		{
			return _data.GetEnumerator();
		}
	}
}