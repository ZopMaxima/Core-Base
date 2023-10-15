// IStreamExtensionsHashSet.cs
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
	public static class IStreamExtensionsHashSet
	{
		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<bool> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteBoolean(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<sbyte> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteSByte(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<short> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteInt16(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<int> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteInt32(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<long> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteInt64(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<byte> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteByte(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<ushort> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteUInt16(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<uint> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteUInt32(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<ulong> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteUInt64(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<float> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteSingle(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<double> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteDouble(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<decimal> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteDecimal(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<char> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteChar(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<string> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteString(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<Vector2> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteVector2(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<Vector3> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteVector3(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<Vector4> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteVector4(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<Quaternion> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteQuaternion(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<Color> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteColor(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<DateTime> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteDateTime(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<IStream> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteStream(v);
				}
			}
		}

		/// <summary>
		/// Write a set of values.
		/// </summary>
		public static void WriteHashSet(this IStream stream, HashSet<ISerializable> value)
		{
			if (value == null)
			{
				stream.WriteInt32(-1);
			}
			else
			{
				int length = value.Count;
				stream.WriteInt32(length);
				foreach (var v in value)
				{
					stream.WriteSerializable(v);
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<bool> ReadBooleanHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<bool> value = new HashSet<bool>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadBoolean());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<sbyte> ReadSByteHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<sbyte> value = new HashSet<sbyte>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadSByte());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<short> ReadInt16HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<short> value = new HashSet<short>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadInt16());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<int> ReadInt32HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<int> value = new HashSet<int>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadInt32());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<long> ReadInt64HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<long> value = new HashSet<long>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadInt64());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<byte> ReadByteHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<byte> value = new HashSet<byte>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadByte());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<ushort> ReadUInt16HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<ushort> value = new HashSet<ushort>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadUInt16());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<uint> ReadUInt32HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<uint> value = new HashSet<uint>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadUInt32());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<ulong> ReadUInt64HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<ulong> value = new HashSet<ulong>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadUInt64());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<float> ReadSingleHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<float> value = new HashSet<float>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadSingle());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<double> ReadDoubleHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<double> value = new HashSet<double>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadDouble());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<decimal> ReadDecimalHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<decimal> value = new HashSet<decimal>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadDecimal());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<char> ReadCharHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<char> value = new HashSet<char>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadChar());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<string> ReadStringHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<string> value = new HashSet<string>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadString());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<Vector2> ReadVector2HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<Vector2> value = new HashSet<Vector2>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadVector2());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<Vector3> ReadVector3HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<Vector3> value = new HashSet<Vector3>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadVector3());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<Vector4> ReadVector4HashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<Vector4> value = new HashSet<Vector4>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadVector4());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<Quaternion> ReadQuaternionHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<Quaternion> value = new HashSet<Quaternion>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadQuaternion());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<Color> ReadColorHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<Color> value = new HashSet<Color>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadColor());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<DateTime> ReadDateTimeHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<DateTime> value = new HashSet<DateTime>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadDateTime());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<IStream> ReadStreamHashSet(this IStream stream)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<IStream> value = new HashSet<IStream>();
				for (int i = 0; i < length; i++)
				{
					value.Add(stream.ReadStream());
				}
				return value;
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static HashSet<ISerializable> ReadSerializableHashSet(this IStream stream, Func<ISerializable> constructor)
		{
			int length = stream.ReadInt32();
			if (length < 0)
			{
				return null;
			}
			else
			{
				HashSet<ISerializable> value = new HashSet<ISerializable>();
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