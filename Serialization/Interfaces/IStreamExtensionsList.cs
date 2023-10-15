// IStreamExtensionsList.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zop.Serialization
{
	/// <summary>
	/// More methods for the lazy.
	/// </summary>
	public static class IStreamExtensionsList
	{
		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<bool> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteBoolean(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<sbyte> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteSByte(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<short> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteInt16(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<int> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteInt32(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<long> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteInt64(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<byte> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteByte(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<ushort> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteUInt16(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<uint> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteUInt32(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<ulong> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteUInt64(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<float> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteSingle(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<double> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteDouble(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<decimal> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteDecimal(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<char> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteChar(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<string> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteString(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<Vector2> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteVector2(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<Vector3> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteVector3(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<Vector4> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteVector4(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<Quaternion> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteQuaternion(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<Color> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteColor(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<DateTime> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteDateTime(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<IStream> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteStream(value[i]);
				}
			}
		}

		/// <summary>
		/// Write a list of values.
		/// </summary>
		public static void WriteList(this IStream stream, List<ISerializable> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				for (int i = 0; i < length; i++)
				{
					stream.WriteSerializable(value[i]);
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<bool> ReadBooleanList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<bool> value = new List<bool>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadBoolean());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<sbyte> ReadSByteList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<sbyte> value = new List<sbyte>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadSByte());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<short> ReadInt16List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<short> value = new List<short>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadInt16());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<int> ReadInt32List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<int> value = new List<int>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadInt32());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<long> ReadInt64List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<long> value = new List<long>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadInt64());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<byte> ReadByteList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<byte> value = new List<byte>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadByte());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<ushort> ReadUInt16List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<ushort> value = new List<ushort>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadUInt16());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<uint> ReadUInt32List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<uint> value = new List<uint>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadUInt32());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<ulong> ReadUInt64List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<ulong> value = new List<ulong>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadUInt64());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<float> ReadSingleList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<float> value = new List<float>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadSingle());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<double> ReadDoubleList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<double> value = new List<double>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadDouble());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<decimal> ReadDecimalList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<decimal> value = new List<decimal>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadDecimal());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<char> ReadCharList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<char> value = new List<char>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadChar());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<string> ReadStringList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<string> value = new List<string>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadString());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<Vector2> ReadVector2List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<Vector2> value = new List<Vector2>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadVector2());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<Vector3> ReadVector3List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<Vector3> value = new List<Vector3>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadVector3());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<Vector4> ReadVector4List(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<Vector4> value = new List<Vector4>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadVector4());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<Quaternion> ReadQuaternionList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<Quaternion> value = new List<Quaternion>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadQuaternion());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<Color> ReadColorList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<Color> value = new List<Color>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadColor());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<DateTime> ReadDateTimeList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<DateTime> value = new List<DateTime>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadDateTime());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<IStream> ReadStreamList(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<IStream> value = new List<IStream>(length);
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadStream());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static List<ISerializable> ReadSerializableList(this IStream stream, Func<ISerializable> constructor)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				List<ISerializable> value = new List<ISerializable>(length);
				if (constructor != null)
				{
					for (int i = 0; i < length; i++)
					{
						ISerializable s = constructor();
						stream.ReadSerializable(s);
						value.Add(s);
					}
				}
				return value;
			}
		}
	}
}