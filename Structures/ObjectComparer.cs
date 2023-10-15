// UnityUpdate.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System.Collections.Generic;

namespace Zop
{
	/// <summary>
	/// Compare system objects.
	/// </summary>
	public struct ObjectComparer : IEqualityComparer<object>
	{
		public static readonly ObjectComparer Instance = new ObjectComparer();

		/// <summary>
		/// Returns true if these objects are equal.
		/// </summary>
		public new bool Equals(object one, object two)
		{
			return ReferenceEquals(one, two);
		}

		/// <summary>
		/// Returns a hash code for this object.
		/// </summary>
		public int GetHashCode(object obj)
		{
			return obj == null ? 0 : obj.GetHashCode();
		}
	}
}