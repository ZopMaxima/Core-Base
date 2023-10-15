// IStreamExtensionsArray.cs
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
	public static class IStreamExtensionsArray
	{
		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, bool[] value)
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
					stream.WriteBoolean(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, sbyte[] value)
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
					stream.WriteSByte(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, short[] value)
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
					stream.WriteInt16(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, int[] value)
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
					stream.WriteInt32(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, long[] value)
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
					stream.WriteInt64(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, byte[] value)
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
					stream.WriteByte(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, ushort[] value)
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
					stream.WriteUInt16(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, uint[] value)
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
					stream.WriteUInt32(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, ulong[] value)
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
					stream.WriteUInt64(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, float[] value)
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
					stream.WriteSingle(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, double[] value)
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
					stream.WriteDouble(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, decimal[] value)
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
					stream.WriteDecimal(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, char[] value)
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
					stream.WriteChar(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, string[] value)
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
					stream.WriteString(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, Vector2[] value)
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
					stream.WriteVector2(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, Vector3[] value)
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
					stream.WriteVector3(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, Vector4[] value)
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
					stream.WriteVector4(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, Quaternion[] value)
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
					stream.WriteQuaternion(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, Color[] value)
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
					stream.WriteColor(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, DateTime[] value)
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
					stream.WriteDateTime(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, IStream[] value)
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
					stream.WriteStream(value[i]);
				}
			}
		}

		/// <summary>
		/// Write an array of values.
		/// </summary>
		public static void WriteArray(this IStream stream, ISerializable[] value)
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
					stream.WriteSerializable(value[i]);
				}
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static bool[] ReadBooleanArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				bool[] value = new bool[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadBoolean();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static sbyte[] ReadSByteArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				sbyte[] value = new sbyte[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadSByte();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static short[] ReadInt16Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				short[] value = new short[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadInt16();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static int[] ReadInt32Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				int[] value = new int[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadInt32();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static long[] ReadInt64Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				long[] value = new long[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadInt64();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static byte[] ReadByteArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				byte[] value = new byte[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadByte();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static ushort[] ReadUInt16Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				ushort[] value = new ushort[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadUInt16();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static uint[] ReadUInt32Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				uint[] value = new uint[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadUInt32();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static ulong[] ReadUInt64Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				ulong[] value = new ulong[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadUInt64();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static float[] ReadSingleArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				float[] value = new float[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadSingle();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static double[] ReadDoubleArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				double[] value = new double[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadDouble();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static decimal[] ReadDecimalArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				decimal[] value = new decimal[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadDecimal();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static char[] ReadCharArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				char[] value = new char[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadChar();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static string[] ReadStringArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				string[] value = new string[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadString();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Vector2[] ReadVector2Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Vector2[] value = new Vector2[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadVector2();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Vector3[] ReadVector3Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Vector3[] value = new Vector3[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadVector3();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Vector4[] ReadVector4Array(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Vector4[] value = new Vector4[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadVector4();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Quaternion[] ReadQuaternionArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Quaternion[] value = new Quaternion[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadQuaternion();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static Color[] ReadColorArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				Color[] value = new Color[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadColor();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static DateTime[] ReadDateTimeArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				DateTime[] value = new DateTime[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadDateTime();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static IStream[] ReadStreamArray(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				IStream[] value = new IStream[length];
				for (int i = 0; i < length; i++)
				{
					value[i] = stream.ReadStream();
				}
				return value;
			}
		}

		/// <summary>
		/// Read an array of values.
		/// </summary>
		public static ISerializable[] ReadSerializableArray(this IStream stream, Func<ISerializable> constructor)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				ISerializable[] value = new ISerializable[length];
				if (constructor != null)
				{
					for (int i = 0; i < length; i++)
					{
						value[i] = constructor();
						stream.ReadSerializable(value[i]);
					}
				}
				return value;
			}
		}
	}
}