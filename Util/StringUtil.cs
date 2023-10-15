// StringUtil.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// Extend the string class.
/// </summary>
public static class StringUtil
{
	public const string NULL = "null";

	private static object _lockWhite = new object();
	private static StringBuilder _buildWhite = new StringBuilder();
	private static object _lockExpand = new object();
	private static StringBuilder _buildExpand = new StringBuilder();

	/// <summary>
	/// Returns true if a string is null or has no legible characters.
	/// </summary>
	public static bool IsNullOrBlank(this string source)
	{
		// The easy part.
		if (source == null)
			return true;

		// Test white space.
		int end = source.Length;
		for (int i = 0; i < end; i++)
		{
			char c = source[i];
			if (!char.IsWhiteSpace(c) && !char.IsControl(c))
			{
				return false;
			}
		}

		// Return
		return true;
	}

	/// <summary>
	/// Returns true if this string contains another, ignoring letter case.
	/// </summary>
	public static bool ContainsIgnoreCase(this string self, string other)
	{
		// Cannot be null.
		if (self == null || other == null)
			return false;

		// Return
		return CultureInfo.InvariantCulture.CompareInfo.IndexOf(self, other, CompareOptions.OrdinalIgnoreCase) >= 0;
	}

	/// <summary>
	/// Returns this string with all whitespace characters removed.
	/// </summary>
	public static string RemoveWhiteSpaces(this string self)
	{
		lock (_lockWhite)
		{
			_buildWhite.Clear();

			// Append non-whitespace.
			int end = self.Length;
			for (int i = 0; i < end; i++)
			{
				char c = self[i];
				if (!char.IsWhiteSpace(c))
				{
					_buildWhite.Append(c);
				}
			}

			// Complete
			self = _buildWhite.ToString();
		}

		// Return
		return self;
	}

	/// <summary>
	/// Returns a string spaced by case transitions and underscores.
	/// eg. High_SpeedRacing --> High-Speed Racing
	/// </summary>
	public static string ExpandName(this string s)
	{
		return (s != null) ? (Expand(s)) : (NULL);
	}

	/// <summary>
	/// Returns a string spaced by case transitions and underscores.
	/// eg. High_SpeedRacing --> High-Speed Racing
	/// </summary>
	public static string ExpandName(this Type t)
	{
		return (t != null) ? (Expand(t.ToString())) : (NULL);
	}

	/// <summary>
	/// Returns a string spaced by case transitions and underscores.
	/// eg. High_SpeedRacing --> High-Speed Racing
	/// </summary>
	public static string ExpandName(this Enum e)
	{
		return (e != null) ? (Expand(e.ToString())) : (NULL);
	}

	/// <summary>
	/// Returns a string spaced by case transitions and underscores for each item.
	/// eg. High_SpeedRacing --> High-Speed Racing
	/// </summary>
	public static string[] ExpandNames(this Enum e)
	{
		string[] names;
		if (e != null)
		{
			names = Enum.GetNames(e.GetType());
			for (int i = 0; i < names.Length; i++)
			{
				names[i] = Expand(names[i]);
			}
		}
		else
		{
			names = Array.Empty<string>();
		}

		// Return
		return names;
	}

	/// <summary>
	/// Returns a string spaced by case transitions and underscores for each item.
	/// eg. High_SpeedRacing --> High-Speed Racing
	/// 
	/// NOTE: Assumes this type is an enum, capable returning multiple names.
	/// </summary>
	public static string[] ExpandNamesAsEnum(this Type type)
	{
		string[] names;
		if (type != null)
		{
			names = Enum.GetNames(type);
			for (int i = 0; i < names.Length; i++)
			{
				names[i] = Expand(names[i]);
			}
		}
		else
		{
			names = Array.Empty<string>();
		}

		// Return
		return names;
	}

	/// <summary>
	/// Apply a space where lower-case changes to upper-case.
	/// Convert Underscore to hyphen.
	/// </summary>
	private static string Expand(string s)
	{
		lock (_lockExpand)
		{
			_buildExpand.Clear();
			_buildExpand.Append(s);

			// Search
			bool trim = true;
			for (int i = s.Length - 1; i >= 0; i--)
			{
				char c = s[i];

				// Try end trim.
				if (trim)
				{
					if (char.IsWhiteSpace(c))
					{
						_buildExpand.Remove(i, 1);
					}
					else
					{
						trim = false;
					}
				}

				// Try replace, else start trim.
				if (i > 0)
				{
					if (c == '_')
					{
						_buildExpand[i] = '-';
					}
					else if (char.IsUpper(c) && char.IsLower(s[i - 1]))
					{
						_buildExpand.Insert(i, ' ');
					}
				}
				else
				{
					if (char.IsWhiteSpace(c))
					{
						_buildExpand.Remove(i, 1);
						i++;
					}
				}
			}

			// Complete
			s = _buildExpand.ToString();
		}

		// Return
		return s;
	}

	/// <summary>
	/// Returns an integer or 0 by scanning right-to-left.
	/// </summary>
	public static int ParseInt(this string source, int start = -1, int length = -1)
	{
		return (int)ParseLong(source, start, length);
	}

	/// <summary>
	/// Returns an integer or 0 by scanning right-to-left.
	/// </summary>
	public static long ParseLong(this string source, int start = -1, int length = -1)
	{
		long result = 0;

		// Got nothing.
		int sL;
		if (source == null || (sL = source.Length) == 0)
			return result;

		// Clamp
		if (start < 0)
		{
			start = 0;
		}
		else if (start >= sL)
		{
			start = sL - 1;
		}
		if (length < 0)
		{
			length = sL - start;
		}
		else if (start + length > sL)
		{
			length += sL - (start + length);
		}

		// Count
		bool found = false;
		int pow = 1;
		for (int i = start + length - 1; i >= start; i--)
		{
			int c = (int)source[i];

			// Signed, end here.
			if (c == 45 && found)
			{
				result *= -1;
				break;
			}

			// Comma, skip.
			if (c == 44)
			{
				continue;
			}

			// Decimal, truncate the value.
			if (c == 46)
			{
				result = 0;
				pow = 1;
				continue;
			}

			// Add numbers.
			if (c >= 48 && c <= 57)
			{
				found = true;
				result += (c - 48) * pow;
				pow *= 10;
			}
			else if (found)
			{
				// Garbage
				break;
			}
		}

		// Return
		return result;
	}

	/// <summary>
	/// Returns an integer or 0 by scanning right-to-left.
	/// </summary>
	public static uint ParseUInt(this string source, int start = -1, int length = -1)
	{
		return (uint)ParseULong(source, start, length);
	}

	/// <summary>
	/// Returns an integer or 0 by scanning right-to-left.
	/// </summary>
	public static ulong ParseULong(this string source, int start = -1, int length = -1)
	{
		ulong result = 0;

		// Got nothing.
		int sL;
		if (source == null || (sL = source.Length) == 0)
			return result;

		// Clamp
		if (start < 0)
		{
			start = 0;
		}
		else if (start >= sL)
		{
			start = sL - 1;
		}
		if (length < 0)
		{
			length = sL - start;
		}
		else if (start + length > sL)
		{
			length += sL - (start + length);
		}

		// Count
		bool found = false;
		int pow = 1;
		for (int i = start + length - 1; i >= start; i--)
		{
			int c = (int)source[i];

			// Comma, skip.
			if (c == 44)
			{
				continue;
			}

			// Decimal, truncate the value.
			if (c == 46)
			{
				result = 0;
				pow = 1;
				continue;
			}

			// Add numbers.
			if (c >= 48 && c <= 57)
			{
				found = true;
				result += (uint)((c - 48) * pow);
				pow *= 10;
			}
			else if (found)
			{
				// Garbage
				break;
			}
		}

		// Return
		return result;
	}

	/// <summary>
	/// Returns a float or 0 by scanning right-to-left.
	/// </summary>
	public static float ParseFloat(this string source, int start = -1, int length = -1)
	{
		float result = 0;

		// Got nothing.
		int sL;
		if (source == null || (sL = source.Length) == 0)
			return result;

		// Clamp
		if (start < 0)
		{
			start = 0;
		}
		else if (start >= sL)
		{
			start = sL - 1;
		}
		if (length < 0)
		{
			length = sL - start;
		}
		else if (start + length > sL)
		{
			length += sL - (start + length);
		}

		// Count
		bool found = false;
		int pow = 1;
		for (int i = start + length - 1; i >= start; i--)
		{
			int c = (int)source[i];

			// Signed, end here.
			if (c == 45 && found)
			{
				result *= -1;
				break;
			}

			// Comma, skip.
			if (c == 44)
			{
				continue;
			}

			// Decimal, divide the value.
			if (c == 46 && found)
			{
				result /= pow;
				pow = 1;
				continue;
			}

			// Add numbers.
			if (c >= 48 && c <= 57)
			{
				found = true;
				result += (c - 48) * pow;
				pow *= 10;
			}
			else if (found)
			{
				// Garbage
				break;
			}
		}

		// Return
		return result;
	}

	/// <summary>
	/// Returns true if the string or substring is only a number.
	/// </summary>
	public static bool IsOnlyNumber(this string source, int start = -1, int length = -1)
	{
		// Got nothing.
		int sL;
		if (source == null || (sL = source.Length) == 0)
			return false;

		// Clamp
		if (start < 0)
		{
			start = 0;
		}
		else if (start >= sL)
		{
			start = sL - 1;
		}
		if (length < 0)
		{
			length = sL - start;
		}
		else if (start + length > sL)
		{
			length += sL - (start + length);
		}

		// Count
		for (int i = start + length - 1; i >= start; i--)
		{
			int c = (int)source[i];

			// Signed, end here.
			if (c == 45)
			{
				if (i == start)
				{
					continue;
				}
				else
				{
					return false;
				}
			}

			// Comma, Decimal, skip.
			if (c == 44 || c == 46)
			{
				continue;
			}

			// Digits
			if (c < 48 || c > 57)
			{
				return false;
			}
		}

		// Return
		return true;
	}

	/// <summary>
	/// Compare two strings with the consideration that numbers have value beyond ASCII.
	/// An integer found within the string is evaluated as a number, instead of its individual characters.
	/// </summary>
	public static int CompareToWithIntegers(this string self, string other)
	{
		// Null compares less than all objects, except for null.
		if (self == null)
			return (other == null) ? (0) : (-1);

		// A number does not exist if one is null or empty.
		if (string.IsNullOrEmpty(self) || string.IsNullOrEmpty(other))
			return self.CompareTo(other);

		// Indeces and lengths of the integer within self and other.
		int iS;
		int lS;
		int iO;
		int lO;

		// Check if both strings contain a number at the same index.
		if (GetFirstInt(self, out iS, out lS) && GetFirstInt(other, out iO, out lO) && iS == iO)
		{
			// Check if both strings start equal.
			for (int i = 0; i < iS; i++)
			{
				if (self[i] != other[i])
				{
					return self[i].CompareTo(other[i]);
				}
			}

			// Check if both numbers are the same length.
			if (lS != lO)
			{
				return lS.CompareTo(lO);
			}

			// Check if both numbers are equal.
			for (int i = iS; i < iS + lS; i++)
			{
				if (self[i] != other[i])
				{
					return self[i].CompareTo(other[i]);
				}
			}

			// Recursion
			return CompareToWithIntegers(self.Substring(iS + lS), other.Substring(iO + lO));
		}
		else
		{
			return self.CompareTo(other);
		}
	}

	/// <summary>
	/// Returns true if this string contains an integer.
	/// The index of the integer and its length are assigned when found.
	/// </summary>
	public static bool GetFirstInt(this string self, out int index, out int length, int start = 0)
	{
		bool result = false;
		index = -1;
		length = 0;

		// Do not parse a null.
		if (string.IsNullOrEmpty(self))
			return result;

		// Parse
		for (int i = start; i < self.Length; i++)
		{
			if (index < 0)
			{
				if (char.IsDigit(self[i]))
				{
					length++;
					index = i;
					result = true;
				}
			}
			else
			{
				if (char.IsDigit(self[i]))
				{
					length++;
				}
				else
				{
					break;
				}
			}
		}

		// Return
		return result;
	}

	/// <summary>
	/// Find the most relevant matches to the searched string.
	/// 
	/// Returns empty if there are no matches.
	/// </summary>
	public static List<T> Search<T>(T[] items, string search, Func<T, string> toString = null)
	{
		List<T> result = new List<T>();
		List<string> values = new List<string>();

		// Search
		if (items != null)
		{
			bool hasToString = toString != null;

			// Find the closest result.
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] == null)
					continue;

				// Evaluate
				string value = (hasToString) ? (toString.Try(items[i])) : (items[i].ToString());
				if (value.ContainsIgnoreCase(search))
				{
					result.Add(items[i]);
					values.Add(value);
				}
			}
		}

		// Sort
		RelevanceSort(result, values, search);

		// Return
		return result;
	}

	/// <summary>
	/// Find the most relevant matches to the searched string.
	/// 
	/// Returns empty if there are no matches.
	/// </summary>
	public static List<T> Search<T>(List<T> items, string search, Func<T, string> toString = null)
	{
		List<T> result = new List<T>();
		List<string> values = new List<string>();

		// Search
		if (items != null)
		{
			bool hasToString = toString != null;

			// Find the closest result.
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i] == null)
					continue;

				// Evaluate
				string value = (hasToString) ? (toString.Try(items[i])) : (items[i].ToString());
				if (value.ContainsIgnoreCase(search))
				{
					result.Add(items[i]);
					values.Add(value);
				}
			}
		}

		// Sort
		RelevanceSort(result, values, search);

		// Return
		return result;
	}

	/// <summary>
	/// Repeat work from the search methods.
	/// </summary>
	private static void RelevanceSort<T>(List<T> result, List<string> values, string search)
	{
		if (result.Count > 1)
		{
			int jEnd = values.Count;
			int iEnd = jEnd - 1;
			for (int i = 0; i < iEnd; i++)
			{
				int low = i;
				for (int j = i + 1; j < jEnd; j++)
				{
					if (values[j].CompareToWithRelevance(values[low], search) < 0)
					{
						low = j;
					}
				}

				// Swap
				if (low > i)
				{
					T item = result[i];
					result[i] = result[low];
					result[low] = item;
					string value = values[i];
					values[i] = values[low];
					values[low] = value;
				}
			}
		}
	}

	/// <summary>
	/// Compare this string to the other using search relevance first.
	/// </summary>
	public static int CompareToWithRelevance(this string self, string other, string search)
	{
		// Null compares less than all objects, except for null.
		if (self == null)
			return (other == null) ? (0) : (-1);

		// This is a failed search if we got null or empty.
		if (string.IsNullOrEmpty(self) || string.IsNullOrEmpty(other) || string.IsNullOrEmpty(search))
			return self.CompareToWithIntegers(other);

		// Search results...
		int iS;
		int sS;
		self.ScoreIndexOf(search, out iS, out sS);
		int iO;
		int sO;
		other.ScoreIndexOf(search, out iO, out sO);

		// Earlier placement of the search string is most important.
		if (iS >= 0)
		{
			if (iO >= 0)
			{
				if (iS == iO)
				{
					// Select shorter matches, meaning the match is a higher percentage of the word.
					if (self.Length == other.Length)
					{
						// At equal length, compare scores.
						if (sS == sO)
						{
							return self.CompareToWithIntegers(other);
						}
						else
						{
							return sS.CompareTo(sO);
						}
					}
					else
					{
						return self.Length.CompareTo(other.Length);
					}
				}
				else
				{
					return iS.CompareTo(iO);
				}
			}
			else
			{
				return -1;
			}
		}
		else if (sO >= 0)
		{
			return 1;
		}

		// Apparently this search was all for nothing.
		return self.CompareToWithIntegers(other);
	}

	/// <summary>
	/// Compare this string to the other using search relevance first.
	/// </summary>
	private static void ScoreIndexOf(this string value, string search, out int index, out int score)
	{
		index = -1;
		score = -1;

		// Nope
		if (string.IsNullOrEmpty(search))
			return;

		// Search
		int jEnd = search.Length;
		int iEnd = value.Length - jEnd;
		for (int i = 0; i <= iEnd; i++)
		{
			if (char.ToLowerInvariant(value[i]) == char.ToLowerInvariant(search[0]))
			{
				bool match = true;
				int matches = 0;
				if (value[i] == search[0])
				{
					matches++;
				}

				// Match
				for (int j = 1; j < jEnd; j++)
				{
					char cV = value[i + j];
					char cS = search[j];
					if (char.ToLowerInvariant(cV) == char.ToLowerInvariant(cS))
					{
						if (cV == cS)
						{
							matches++;
						}
					}
					else
					{
						match = false;
						break;
					}
				}

				// Select this index.
				if (match)
				{
					if (matches == search.Length)
					{
						index = i;
						score = matches;
						break;
					}
					else
					{
						if (matches > score)
						{
							index = i;
							score = matches;
						}
					}
				}
			}
		}
	}
}