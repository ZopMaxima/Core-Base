// IStreamExtensionsArray2D.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using UnityEngine;

namespace Zop.Serialization
{
	/// <summary>
	/// More methods for the lazy.
	/// </summary>
	public static class IStreamExtensionsArray2D
	{
		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, bool[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, sbyte[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, short[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, int[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, long[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, byte[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, ushort[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, uint[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, ulong[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, float[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, double[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, decimal[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, char[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, string[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, Vector2[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, Vector3[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, Vector4[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, Quaternion[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, Color[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, DateTime[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, IStream[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray2D(this IStream stream, ISerializable[][] value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Length;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteArray(value[i]);
				}
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static bool[][] ReadBooleanArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				bool[][] value = new bool[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadBooleanArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static sbyte[][] ReadSByteArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				sbyte[][] value = new sbyte[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadSByteArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static short[][] ReadInt16Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				short[][] value = new short[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadInt16Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static int[][] ReadInt32Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				int[][] value = new int[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadInt32Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static long[][] ReadInt64Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				long[][] value = new long[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadInt64Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static byte[][] ReadByteArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				byte[][] value = new byte[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadByteArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static ushort[][] ReadUInt16Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				ushort[][] value = new ushort[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadUInt16Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static uint[][] ReadUInt32Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				uint[][] value = new uint[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadUInt32Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static ulong[][] ReadUInt64Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				ulong[][] value = new ulong[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadUInt64Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static float[][] ReadSingleArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				float[][] value = new float[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadSingleArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static double[][] ReadDoubleArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				double[][] value = new double[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadDoubleArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static decimal[][] ReadDecimalArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				decimal[][] value = new decimal[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadDecimalArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static char[][] ReadCharArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				char[][] value = new char[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadCharArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static string[][] ReadStringArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				string[][] value = new string[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadStringArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Vector2[][] ReadVector2Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Vector2[][] value = new Vector2[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadVector2Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Vector3[][] ReadVector3Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Vector3[][] value = new Vector3[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadVector3Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Vector4[][] ReadVector4Array2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Vector4[][] value = new Vector4[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadVector4Array();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Quaternion[][] ReadQuaternionArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Quaternion[][] value = new Quaternion[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadQuaternionArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Color[][] ReadColorArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Color[][] value = new Color[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadColorArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static DateTime[][] ReadDateTimeArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				DateTime[][] value = new DateTime[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadDateTimeArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static IStream[][] ReadStreamArray2D(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				IStream[][] value = new IStream[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadStreamArray();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static ISerializable[][] ReadSerializableArray2D(this IStream stream, Func<ISerializable> constructor)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				ISerializable[][] value = new ISerializable[length][];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadSerializableArray(constructor);
				}
				return value;
			}
		}
	}
}