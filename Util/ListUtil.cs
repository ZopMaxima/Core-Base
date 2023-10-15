// ArrayUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using System.Collections.Generic;

/// <summary>
/// Extend the list class.
/// </summary>
public static class ListUtil
{
	/// <summary>
	/// Returns true if one list contains anything from the other.
	/// </summary>
	public static bool ContainsAny<T>(this List<T> list, List<T> other)
	{
		// Cannot be null.
		if (list == null || other == null)
			return false;

		// Easy
		if ((object)list == (object)other)
			return true;

		// Skip the loops if any are zero.
		int iEnd = list.Count;
		int jEnd = other.Count;
		if (jEnd == 0) // NOTE: Index 'i' is checked by the first loop.
			return false;

		// Compare
		for (int i = 0; i < iEnd; i++)
		{
			T item = list[i];
			if ((object)item == null)
			{
				for (int j = 0; j < jEnd; j++)
				{
					if ((object)other[j] == null)
					{
						return true;
					}
				}
			}
			else
			{
				for (int j = 0; j < jEnd; j++)
				{
					if (item.Equals(other[j]))
					{
						return true;
					}
				}
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns the index of an element that evaluates to true.
	/// </summary>
	public static int IndexOfValue<T>(this List<T> list, Func<T, bool> evaluation)
	{
		// Cannot be null.
		if (list == null || evaluation == null)
			return -1;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (evaluation.Try(list[i]))
			{
				return i;
			}
		}

		// Failed
		return -1;
	}

	/// <summary>
	/// Returns true if an element evaluates to true.
	/// </summary>
	public static bool ContainsValue<T>(this List<T> list, Func<T, bool> evaluation)
	{
		// Cannot be null.
		if (list == null || evaluation == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (evaluation.Try(list[i]))
			{
				return true;
			}
		}

		// Failed
		return false;
	}

	/// <summary>
	/// Returns true if all elements evaluate to true.
	/// </summary>
	public static bool ContainsValueAll<T>(this List<T> list, Func<T, bool> evaluation)
	{
		// Cannot be null.
		if (list == null || evaluation == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (!evaluation.Try(list[i]))
			{
				return false;
			}
		}

		// Passed
		return true;
	}

	/// <summary>
	/// Moves an object to the left by a number of indeces, shifting all objects between.
	/// Returns true if the operation is completed.
	/// </summary>
	public static bool MoveElementLeft<T>(this List<T> list, int index, int length)
	{
		// Send to MoveElementRight.
		if (length < 0)
			return list.MoveElementRight(index, length * -1);

		// Calculations
		int left = index - length;

		// Bounds
		if (list == null || list.Count <= index || left < 0)
			return false;

		// Remove
		T t = list[index];

		// Shift
		for (int i = index; i > left; i--)
		{
			list[i] = list[i - 1];
		}

		// Replace
		list[left] = t;

		// Return
		return true;
	}

	/// <summary>
	/// Moves an object to the right by a number of indeces, shifting all objects between.
	/// Returns true if the operation is completed.
	/// </summary>
	public static bool MoveElementRight<T>(this List<T> list, int index, int length)
	{
		// Send to MoveElementLeft.
		if (length < 0)
			return list.MoveElementLeft(index, length * -1);

		// Calculations
		int right = index + length;

		// Bounds
		if (list == null || index < 0 || right >= list.Count)
			return false;

		// Remove
		T t = list[index];

		// Shift
		for (int i = index; i < right; i++)
		{
			list[i] = list[i + 1];
		}

		// Replace
		list[right] = t;

		// Return
		return true;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsReference<T>(this List<T> list, T value) where T : class
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (object.ReferenceEquals(list[i], value))
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<byte> list, byte value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<sbyte> list, sbyte value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<short> list, short value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<ushort> list, ushort value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<int> list, int value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<uint> list, uint value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<long> list, long value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<ulong> list, ulong value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<float> list, float value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<double> list, double value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}

	/// <summary>
	/// Returns true if the list contains a primitive value.
	///
	/// Skips all of the generic magic in Contains().
	/// </summary>
	public static bool ContainsPrimitive(this List<decimal> list, decimal value)
	{
		// Cannot be null.
		if (list == null)
			return false;

		// Compare
		int end = list.Count;
		for (int i = 0; i < end; i++)
		{
			if (list[i] == value)
			{
				return true;
			}
		}

		// Failed.
		return false;
	}
}