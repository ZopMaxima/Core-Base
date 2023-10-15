// ArrayUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using System.Collections.Generic;

/// <summary>
/// Extend the array class.
/// </summary>
public static class ArrayUtil
{
	/// <summary>
	/// Generate a new array with the reference and append the value.
	/// </summary>
	public static T[] Add<T>(this T[] array, T value)
	{
		Add(ref array, value);
		return array;
	}

	/// <summary>
	/// Generate a new array with the reference and append the value.
	/// </summary>
	public static bool Add<T>(ref T[] array, T value)
	{
		// Cannot be null.
		if (array == null)
			return false;

		// Copy
		T[] temp = array;
		array = new T[temp.Length + 1];
		Array.Copy(temp, array, temp.Length);
		array[temp.Length] = value;
		return true;
	}

	/// <summary>
	/// Generate a new array with the reference and insert the value.
	/// </summary>
	public static T[] Insert<T>(this T[] array, T value, int index)
	{
		Insert(ref array, value, index);
		return array;
	}

	/// <summary>
	/// Generate a new array with the reference and insert the value.
	/// </summary>
	public static bool Insert<T>(ref T[] array, T value, int index)
	{
		// Cannot be null.
		if (array == null)
			return false;

		// Copy
		if (index >= array.Length || array.Length == 0)
		{
			return Add(ref array, value);
		}
		else if (index <= 0)
		{
			T[] temp = array;
			array = new T[temp.Length + 1];
			Array.Copy(temp, 0, array, 1, temp.Length);
			array[0] = value;
			return true;
		}
		else
		{
			T[] temp = array;
			array = new T[temp.Length + 1];
			Array.Copy(temp, array, index);
			array[index] = value;
			Array.Copy(temp, index, array, index + 1, temp.Length - index);
			return true;
		}
	}

	/// <summary>
	/// Generate a new array with the reference and remove the value.
	/// </summary>
	public static T[] Remove<T>(this T[] array, T value)
	{
		Remove(ref array, value);
		return array;
	}

	/// <summary>
	/// Generate a new array with the reference and remove the value.
	/// </summary>
	public static bool Remove<T>(ref T[] array, T value)
	{
		// Cannot be null.
		if (array == null)
			return false;

		// Search and remove.
		int index = array.IndexOf(value);
		return index >= 0 && RemoveAt(ref array, index);
	}

	/// <summary>
	/// Generate a new array with the reference and remove the value.
	/// </summary>
	public static T[] RemoveAt<T>(this T[] array, int index)
	{
		RemoveAt(ref array, index);
		return array;
	}

	/// <summary>
	/// Generate a new array with the reference and remove the value.
	/// </summary>
	public static bool RemoveAt<T>(ref T[] array, int index)
	{
		// Cannot be null.
		if (array == null)
			return false;

		// Range test.
		if (index < 0 || index >= array.Length)
			return false;

		// Copy
		T[] temp = array;
		array = new T[temp.Length - 1];
		if (index > 0)
		{
			Array.Copy(temp, array, index);
		}
		if (index < array.Length - 1)
		{
			Array.Copy(temp, index + 1, array, index, temp.Length - (index + 1));
		}
		return true;
	}

	/// <summary>
	/// Returns the index of a value.
	/// </summary>
	public static int IndexOf<T>(this T[] array, T value)
	{
		// Cannot be null.
		if (array == null)
			return -1;

		// Compare
		int end = array.Length;
		if (value == null)
		{
			for (int i = 0; i < end; i++)
			{
				if (array[i] == null)
				{
					return i;
				}
			}
		}
		else
		{
			for (int i = 0; i < end; i++)
			{
				if (value.Equals(array[i]))
				{
					return i;
				}
			}
		}

		// Failed
		return -1;
	}

	/// <summary>
	/// Returns the index of a value that evaluates to true.
	/// </summary>
	public static int IndexOfValue<T>(this T[] array, Func<T, bool> evaluation)
	{
		// Cannot be null.
		if (array == null || evaluation == null)
			return -1;

		// Compare
		int end = array.Length;
		for (int i = 0; i < end; i++)
		{
			if (evaluation.Try(array[i]))
			{
				return i;
			}
		}

		// Failed
		return -1;
	}

	/// <summary>
	/// Returns true if this array contains a value.
	/// </summary>
	public static bool Contains<T>(this T[] array, T value)
	{
		// Cannot be null.
		if (array == null)
			return false;

		// Compare
		int end = array.Length;
		if (value == null)
		{
			for (int i = 0; i < end; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
		}
		else
		{
			for (int i = 0; i < end; i++)
			{
				if (value.Equals(array[i]))
				{
					return true;
				}
			}
		}

		// Failed
		return false;
	}

	/// <summary>
	/// Returns true if a value evaluates to true.
	/// </summary>
	public static bool ContainsValue<T>(this T[] array, Func<T, bool> evaluation)
	{
		// Cannot be null.
		if (array == null || evaluation == null)
			return false;

		// Compare
		int end = array.Length;
		for (int i = 0; i < end; i++)
		{
			if (evaluation.Try(array[i]))
			{
				return true;
			}
		}

		// Failed
		return false;
	}

	/// <summary>
	/// Returns true if all values evaluate to true.
	/// </summary>
	public static bool ContainsValueAll<T>(this T[] array, Func<T, bool> evaluation)
	{
		// Cannot be null.
		if (array == null || evaluation == null)
			return false;

		// Compare
		int end = array.Length;
		for (int i = 0; i < end; i++)
		{
			if (!evaluation.Try(array[i]))
			{
				return false;
			}
		}

		// Passed
		return true;
	}

	/// <summary>
	/// Moves all array values left by one index.
	/// Returns the left-side value, array[0] or null.
	/// </summary>
	public static T ShiftLeft<T>(this T[] array)
	{
		if (array == null || array.Length == 0)
			return default(T);

		// Removed value.
		T t = array[0];

		// Shift
		for (int i = 0; i < array.Length - 1; i++)
		{
			array[i] = array[i + 1];
		}

		// Nullify last.
		array[array.Length - 1] = default(T);

		// Return
		return t;
	}

	/// <summary>
	/// Moves all array values beyond the index left by one index.
	/// Returns the left-side value, array[index] or null.
	/// </summary>
	public static T ShiftLeft<T>(this T[] array, int index)
	{
		if (array == null || index < 0 || index >= array.Length)
			return default(T);

		// Removed value.
		T t = array[index];

		// Shift
		for (int i = index; i < array.Length - 1; i++)
		{
			array[i] = array[i + 1];
		}

		// Nullify last.
		array[array.Length - 1] = default(T);

		// Return
		return t;
	}

	/// <summary>
	/// Moves all array values right by one index.
	/// Returns the right-side value, array[array.Length - 1] or null.
	/// </summary>
	public static T ShiftRight<T>(this T[] array)
	{
		if (array == null || array.Length == 0)
			return default(T);

		// Removed value.
		T t = array[array.Length - 1];

		// Shift
		for (int i = array.Length - 1; i > 0; i--)
		{
			array[i] = array[i - 1];
		}

		// Nullify last.
		array[0] = default(T);

		// Return
		return t;
	}

	/// <summary>
	/// Moves all array values before the index right by one index.
	/// Returns the right-side value, array[index - 1] or null.
	/// </summary>
	public static T ShiftRight<T>(this T[] array, int index)
	{
		if (array == null || index < 0 || index >= array.Length)
			return default(T);

		// Removed value.
		T t = array[index];

		// Shift
		for (int i = index; i > 0; i--)
		{
			array[i] = array[i - 1];
		}

		// Nullify last.
		array[0] = default(T);

		// Return
		return t;
	}

	/// <summary>
	/// Moves an object to the left by a number of indeces, shifting all objects between.
	/// Returns true if the operation is completed.
	/// </summary>
	public static bool MoveValueLeft<T>(this T[] array, int index, int length)
	{
		// Send to MoveValueRight.
		if (length < 0)
			return array.MoveValueRight(index, length * -1);

		// Calculations
		int left = index - length;

		// Bounds
		if (array == null || array.Length <= index || left < 0)
			return false;

		// Remove
		T t = array[index];

		// Shift
		for (int i = index; i > left; i--)
		{
			array[i] = array[i - 1];
		}

		// Replace
		array[left] = t;

		// Return
		return true;
	}

	/// <summary>
	/// Moves an object to the right by a number of indeces, shifting all objects between.
	/// Returns true if the operation is completed.
	/// </summary>
	public static bool MoveValueRight<T>(this T[] array, int index, int length)
	{
		// Send to MoveValueLeft.
		if (length < 0)
			return array.MoveValueLeft(index, length * -1);

		// Calculations
		int right = index + length;

		// Bounds
		if (array == null || index < 0 || right >= array.Length)
			return false;

		// Remove
		T t = array[index];

		// Shift
		for (int i = index; i < right; i++)
		{
			array[i] = array[i + 1];
		}

		// Replace
		array[right] = t;

		// Return
		return true;
	}

	/// <summary>
	/// Quicksort the array with a defined comparer.
	/// </summary>
	public static void Quicksort<T>(T[] array, Comparer<T> comparer)
	{
		if (array.Length > 1)
		{
			Quicksort(array, comparer, 0, array.Length - 1);
		}
	}

	/// <summary>
	/// Quicksort the array with a defined comparer.
	/// </summary>
	private static void Quicksort<T>(T[] array, Comparer<T> comparer, int left, int right)
	{
		int i = left, j = right;
		var pivot = array[(left + right) / 2];

		while (i <= j)
		{
			while (comparer.Compare(array[i], pivot) < 0)
				i++;

			while (comparer.Compare(array[j], pivot) > 0)
				j--;

			if (i <= j)
			{
				// Swap
				var temp = array[i];
				array[i] = array[j];
				array[j] = temp;

				i++;
				j--;
			}
		}

		// Recursive calls
		if (left < j)
			Quicksort(array, comparer, left, j);

		if (i < right)
			Quicksort(array, comparer, i, right);
	}

	/// <summary>
	/// Quicksort the array.
	/// </summary>
	public static void Quicksort<T>(this T[] array) where T : IComparable<T>
	{
		if (array.Length > 1)
		{
			array.Quicksort(0, array.Length - 1);
		}
	}

	/// <summary>
	/// Quicksort the array.
	/// </summary>
	private static void Quicksort<T>(this T[] array, int left, int right) where T : IComparable<T>
	{
		int i = left, j = right;
		var pivot = array[(left + right) / 2];

		while (i <= j)
		{
			while (array[i].CompareTo(pivot) < 0)
				i++;

			while (array[j].CompareTo(pivot) > 0)
				j--;

			if (i <= j)
			{
				// Swap
				var temp = array[i];
				array[i] = array[j];
				array[j] = temp;

				i++;
				j--;
			}
		}

		// Recursive calls
		if (left < j)
			array.Quicksort(left, j);

		if (i < right)
			array.Quicksort(i, right);
	}
}