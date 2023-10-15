// EnumNameCache.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   January 26, 2021

using System;
using System.Collections.Generic;

namespace Zop
{
	/// <summary>
	/// A base for enum name caching.
	/// </summary>
	public class EnumNameCache<T> where T : Enum
	{
		private readonly Dictionary<T, string> _valueToName;
		private readonly Dictionary<string, T> _nameToValue;

		/// <summary>
		/// Construct with a comparer.
		/// </summary>
		public EnumNameCache(IEqualityComparer<T> comparer)
		{
			_valueToName = new Dictionary<T, string>(comparer);
			_nameToValue = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);
			Array values = Enum.GetValues(typeof(T));
			for (int i = 0; i < values.Length; i++)
			{
				string name = Enum.GetName(typeof(T), values.GetValue(i));
				T value = (T)values.GetValue(i);
				_valueToName.Add(value, name);
				_nameToValue.Add(name, value);
			}
		}

		/// <summary>
		/// Returns a value for the given name.
		/// </summary>
		public T GetValue(string name)
		{
			return _nameToValue.TryGetValue(name, out T result) ? result : default;
		}

		/// <summary>
		/// Returns a name for the given value.
		/// </summary>
		public string GetName(T value)
		{
			return _valueToName.TryGetValue(value, out string result) ? result : string.Empty;
		}
	}
}