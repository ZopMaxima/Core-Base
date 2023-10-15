// IIdentifiable.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 14, 2022

namespace Zop
{
	/// <summary>
	/// An object that may be identified among its peers.
	/// </summary>
	public interface IIdentifiable<T>
	{
		T ID { get; set; }
	}

	/// <summary>
	/// Extend the identifiable class.
	/// </summary>
	public static class IIdentifiableUtil
	{
		public const int UNASSIGNED = 0;
		public const char UNASSIGNED_TOCHAR = '0';
		public const string UNASSIGNED_TOSTRING = "0";

		private const char CHAR_NULL = (char)0;

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<char> id)
		{
			return id.ID != CHAR_NULL && id.ID != UNASSIGNED_TOCHAR;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<string> id)
		{
			return !string.IsNullOrEmpty(id.ID) && id.ID != UNASSIGNED_TOSTRING;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<sbyte> id)
		{
			return id.ID != UNASSIGNED;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<byte> id)
		{
			return id.ID != UNASSIGNED;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<short> id)
		{
			return id.ID != UNASSIGNED;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<ushort> id)
		{
			return id.ID != UNASSIGNED;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<int> id)
		{
			return id.ID != UNASSIGNED;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<uint> id)
		{
			return id.ID != UNASSIGNED;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<long> id)
		{
			return id.ID != UNASSIGNED;
		}

		/// <summary>
		/// Returns true if this object has an assigned ID.
		/// </summary>
		public static bool HasID(this IIdentifiable<ulong> id)
		{
			return id.ID != UNASSIGNED;
		}
	}
}