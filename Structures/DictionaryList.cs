// DictionaryList.cs
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
	/// Automatically create and destroy an internal collection per key.
	/// </summary>
	public class DictionaryList<TKey, TValue> : IEnumerable<KeyValuePair<TKey, List<TValue>>>
	{
		public readonly ReadOnlyDictionary<TKey, List<TValue>> Data;
		public IEqualityComparer<TKey> KeyComparer { get { return _keyComparer; } }

		private readonly Dictionary<TKey, List<TValue>> _data;
		private IEqualityComparer<TKey> _keyComparer;
		private bool _canCompare;
		private bool _canNull;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DictionaryList() : this(null) { }

		/// <summary>
		/// Construct with a key comparer.
		/// </summary>
		public DictionaryList(IEqualityComparer<TKey> keyComparer)
		{
			if (keyComparer != null)
			{
				_data = new Dictionary<TKey, List<TValue>>(keyComparer);
			}
			else
			{
				_data = new Dictionary<TKey, List<TValue>>();
			}
			Data = new ReadOnlyDictionary<TKey, List<TValue>>(_data);
			_keyComparer = keyComparer;
			_canCompare = keyComparer != null;
			_canNull = default(TKey) == null;
		}

		/// <summary>
		/// Returns true if a subset exists.
		/// </summary>
		public bool Has(TKey key)
		{
			return _data.ContainsKey(key);
		}

		/// <summary>
		/// Returns true if a value exists.
		/// </summary>
		public bool Has(TKey key, TValue value)
		{
			return (_data.TryGetValue(key, out List<TValue> subData)) ? (subData.Contains(value)) : (false);
		}

		/// <summary>
		/// Get a subset.
		/// </summary>
		public List<TValue> Get(TKey key)
		{
			return (_data.TryGetValue(key, out List<TValue> subData)) ? (subData) : (null);
		}

		/// <summary>
		/// Get a value.
		/// </summary>
		public TValue Get(TKey key, int index)
		{
			return (index >= 0 && _data.TryGetValue(key, out List<TValue> subData) && subData.Count > index) ? (subData[index]) : (default);
		}

		/// <summary>
		/// Returns true if this subset exists.
		/// </summary>
		public bool TryGet(TKey key, out List<TValue> subData)
		{
			return _data.TryGetValue(key, out subData) && (subData != null);
		}

		/// <summary>
		/// Returns true if this value exists, can return a valid null.
		/// </summary>
		public bool TryGet(TKey key, int index, out TValue value)
		{
			if (index >= 0 && TryGet(key, out List<TValue> subData) && subData.Count > index)
			{
				value = subData[index];
				return true;
			}
			else
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Add a value.
		/// </summary>
		public bool Add(TKey key, TValue value)
		{
			// Null checks.
			if (_canNull && (_canCompare ? _keyComparer.Equals(key, default) : key == null))
			{
				return false;
			}

			// Search
			List<TValue> subData;
			if (!_data.TryGetValue(key, out subData))
			{
				subData = new List<TValue>();
				_data.Add(key, subData);
			}

			// Add
			subData.Add(value);
			return true;
		}

		/// <summary>
		/// Returns true if this value is added, else it is already in the list.
		/// </summary>
		public bool AddIfUnique(TKey key, TValue value)
		{
			// Null checks.
			if (_canNull && (_canCompare ? _keyComparer.Equals(key, default) : key == null))
			{
				return false;
			}

			// Search
			List<TValue> subData;
			if (!_data.TryGetValue(key, out subData))
			{
				subData = new List<TValue>();
				_data.Add(key, subData);
				subData.Add(value);
				return true;
			}
			else if (!subData.Contains(value))
			{
				subData.Add(value);
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Add a subset.
		/// </summary>
		public bool Add(TKey key, TValue[] values)
		{
			// Null checks.
			if (values == null)
			{
				return false;
			}
			if (_canNull && (_canCompare ? _keyComparer.Equals(key, default) : key == null))
			{
				return false;
			}

			// Search
			List<TValue> subData;
			if (!_data.TryGetValue(key, out subData))
			{
				subData = new List<TValue>();
				_data.Add(key, subData);
			}

			// Add
			subData.AddRange(values);
			return true;
		}

		/// <summary>
		/// Add a subset.
		/// </summary>
		public bool Add(TKey key, ICollection<TValue> values)
		{
			// Null checks.
			if (values == null)
			{
				return false;
			}
			if (_canNull && (_canCompare ? _keyComparer.Equals(key, default) : key == null))
			{
				return false;
			}

			// Search
			List<TValue> subData;
			if (!_data.TryGetValue(key, out subData))
			{
				subData = new List<TValue>();
				_data.Add(key, subData);
			}

			// Add
			subData.AddRange(values);
			return true;
		}

		/// <summary>
		/// Set a value.
		/// </summary>
		public bool Set(TKey key, TValue value, int index)
		{
			// Null checks.
			if (_canNull && (_canCompare ? _keyComparer.Equals(key, default) : key == null))
			{
				return false;
			}

			// Search
			List<TValue> subData;
			if (index < 0 || !_data.TryGetValue(key, out subData) || index >= subData.Count)
			{
				return false;
			}

			// Set
			subData[index] = value;
			return true;
		}

		/// <summary>
		/// Set a value.
		/// </summary>
		public bool Set(TKey key, TValue[] values)
		{
			// Null checks.
			if (values == null || values.Length == 0)
			{
				return Remove(key);
			}
			if (_canNull && (_canCompare ? _keyComparer.Equals(key, default) : key == null))
			{
				return false;
			}

			// Search
			List<TValue> subData;
			if (!_data.TryGetValue(key, out subData))
			{
				subData = new List<TValue>();
				_data.Add(key, subData);
			}
			else
			{
				subData.Clear();
			}

			// Add
			subData.AddRange(values);
			return true;
		}

		/// <summary>
		/// Set a value.
		/// </summary>
		public bool Set(TKey key, ICollection<TValue> values)
		{
			// Null checks.
			if (values == null || values.Count == 0)
			{
				return Remove(key);
			}
			if (_canNull && (_canCompare ? _keyComparer.Equals(key, default) : key == null))
			{
				return false;
			}

			// Search
			List<TValue> subData;
			if (!_data.TryGetValue(key, out subData))
			{
				subData = new List<TValue>();
				_data.Add(key, subData);
			}
			else
			{
				subData.Clear();
			}

			// Add
			subData.AddRange(values);
			return true;
		}

		/// <summary>
		/// Remove a subset.
		/// </summary>
		public bool Remove(TKey key)
		{
			return _data.Remove(key);
		}

		/// <summary>
		/// Remove a value.
		/// </summary>
		public bool Remove(TKey key, int index)
		{
			bool result = false;

			// Search
			List<TValue> subData;
			if (_data.TryGetValue(key, out subData))
			{
				if (index >= 0 && index < subData.Count)
				{
					subData.RemoveAt(index);
					result = true;
				}
				if (result && subData.Count == 0)
				{
					_data.Remove(key);
				}
			}

			// Return
			return result;
		}

		/// <summary>
		/// Remove a value.
		/// </summary>
		public bool Remove(TKey key, TValue value)
		{
			bool result = false;

			// Search
			List<TValue> subData;
			if (_data.TryGetValue(key, out subData))
			{
				result = subData.Remove(value);
				if (result && subData.Count == 0)
				{
					_data.Remove(key);
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
		IEnumerator<KeyValuePair<TKey, List<TValue>>> IEnumerable<KeyValuePair<TKey, List<TValue>>>.GetEnumerator()
		{
			return _data.GetEnumerator();
		}
	}
}