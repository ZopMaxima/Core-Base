// DictionaryDuo.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 14, 2022

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Zop
{
	/// <summary>
	/// Automatically create and destroy an internal dictionary per key.
	/// </summary>
	public class DictionaryDuo<TSuperKey, TSubKey, TValue> : IEnumerable<KeyValuePair<TSuperKey, Dictionary<TSubKey, TValue>>>
	{
		public readonly ReadOnlyDictionary<TSuperKey, Dictionary<TSubKey, TValue>> Data;
		public IEqualityComparer<TSuperKey> SuperKeyComparer { get { return _superKeyComparer; } }
		public IEqualityComparer<TSubKey> SubKeyComparer { get { return _subKeyComparer; } }

		private readonly Dictionary<TSuperKey, Dictionary<TSubKey, TValue>> _data;
		private IEqualityComparer<TSuperKey> _superKeyComparer;
		private IEqualityComparer<TSubKey> _subKeyComparer;
		private bool _canSuperCompare;
		private bool _canSubCompare;
		private bool _canSuperNull;
		private bool _canSubNull;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DictionaryDuo() : this(null, null) { }

		/// <summary>
		/// Construct with a superkey comparer.
		/// </summary>
		public DictionaryDuo(IEqualityComparer<TSuperKey> superKeyComparer) : this(superKeyComparer, null) { }

		/// <summary>
		/// Construct with key comparers.
		/// </summary>
		public DictionaryDuo(IEqualityComparer<TSuperKey> superKeyComparer, IEqualityComparer<TSubKey> subKeyComparer)
		{
			if (superKeyComparer != null)
			{
				_data = new Dictionary<TSuperKey, Dictionary<TSubKey, TValue>>(superKeyComparer);
			}
			else
			{
				_data = new Dictionary<TSuperKey, Dictionary<TSubKey, TValue>>();
			}
			Data = new ReadOnlyDictionary<TSuperKey, Dictionary<TSubKey, TValue>>(_data);
			_superKeyComparer = superKeyComparer;
			_subKeyComparer = subKeyComparer;
			_canSuperCompare = superKeyComparer != null;
			_canSubCompare = subKeyComparer != null;
			_canSuperNull = default(TSuperKey) == null;
			_canSubNull = default(TSubKey) == null;
		}

		/// <summary>
		/// Get a value.
		/// </summary>
		public TValue Get(TSuperKey superKey, TSubKey subKey)
		{
			return (_data.TryGetValue(superKey, out Dictionary<TSubKey, TValue> subData)) ? (subData.TryGetValue(subKey, out TValue value) ? (value) : (default)) : (default);
		}

		/// <summary>
		/// Returns true if this value exists, can return a valid null.
		/// </summary>
		public bool TryGet(TSuperKey superKey, TSubKey subKey, out TValue value)
		{
			if (_data.TryGetValue(superKey, out Dictionary<TSubKey, TValue> subData) && subData.TryGetValue(subKey, out value))
			{
				return true;
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Set a value.
		/// </summary>
		public bool Set(TSuperKey superKey, TSubKey subKey, TValue value)
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
			Dictionary<TSubKey, TValue> subData;
			if (!_data.TryGetValue(superKey, out subData))
			{
				subData = (_canSubCompare) ? (new Dictionary<TSubKey, TValue>(_subKeyComparer)) : (new Dictionary<TSubKey, TValue>());
				_data.Add(superKey, subData);
			}

			// Set
			subData[subKey] = value;
			return true;
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
			Dictionary<TSubKey, TValue> subData;
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
		IEnumerator<KeyValuePair<TSuperKey, Dictionary<TSubKey, TValue>>> IEnumerable<KeyValuePair<TSuperKey, Dictionary<TSubKey, TValue>>>.GetEnumerator()
		{
			return _data.GetEnumerator();
		}
	}
}