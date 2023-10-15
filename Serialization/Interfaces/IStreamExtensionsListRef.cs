// IStreamExtensionsListRef.cs
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
	public static class IStreamExtensionsListRef
	{
		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadBooleanList(this IStream stream, ref List<bool> list)
		{
			if (list == null)
			{
				list = stream.ReadBooleanList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadBoolean());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadSByteList(this IStream stream, ref List<sbyte> list)
		{
			if (list == null)
			{
				list = stream.ReadSByteList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadSByte());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadInt16List(this IStream stream, ref List<short> list)
		{
			if (list == null)
			{
				list = stream.ReadInt16List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadInt16());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadInt32List(this IStream stream, ref List<int> list)
		{
			if (list == null)
			{
				list = stream.ReadInt32List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadInt32());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadInt64List(this IStream stream, ref List<long> list)
		{
			if (list == null)
			{
				list = stream.ReadInt64List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadInt64());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadByteList(this IStream stream, ref List<byte> list)
		{
			if (list == null)
			{
				list = stream.ReadByteList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadByte());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadUInt16List(this IStream stream, ref List<ushort> list)
		{
			if (list == null)
			{
				list = stream.ReadUInt16List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadUInt16());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadUInt32List(this IStream stream, ref List<uint> list)
		{
			if (list == null)
			{
				list = stream.ReadUInt32List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadUInt32());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadUInt64List(this IStream stream, ref List<ulong> list)
		{
			if (list == null)
			{
				list = stream.ReadUInt64List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadUInt64());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadSingleList(this IStream stream, ref List<float> list)
		{
			if (list == null)
			{
				list = stream.ReadSingleList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadSingle());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadDoubleList(this IStream stream, ref List<double> list)
		{
			if (list == null)
			{
				list = stream.ReadDoubleList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadDouble());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadDecimalList(this IStream stream, ref List<decimal> list)
		{
			if (list == null)
			{
				list = stream.ReadDecimalList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadDecimal());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadCharList(this IStream stream, ref List<char> list)
		{
			if (list == null)
			{
				list = stream.ReadCharList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadChar());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadStringList(this IStream stream, ref List<string> list)
		{
			if (list == null)
			{
				list = stream.ReadStringList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadString());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadVector2List(this IStream stream, ref List<Vector2> list)
		{
			if (list == null)
			{
				list = stream.ReadVector2List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadVector2());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadVector3List(this IStream stream, ref List<Vector3> list)
		{
			if (list == null)
			{
				list = stream.ReadVector3List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadVector3());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadVector4List(this IStream stream, ref List<Vector4> list)
		{
			if (list == null)
			{
				list = stream.ReadVector4List();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadVector4());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadQuaternionList(this IStream stream, ref List<Quaternion> list)
		{
			if (list == null)
			{
				list = stream.ReadQuaternionList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadQuaternion());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadColorList(this IStream stream, ref List<Color> list)
		{
			if (list == null)
			{
				list = stream.ReadColorList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadColor());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadDateTimeList(this IStream stream, ref List<DateTime> list)
		{
			if (list == null)
			{
				list = stream.ReadDateTimeList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadDateTime());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadStreamList(this IStream stream, ref List<IStream> list)
		{
			if (list == null)
			{
				list = stream.ReadStreamList();
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					list.Add(stream.ReadStream());
				}
			}
		}

		/// <summary>
		/// Read a list of values.
		/// </summary>
		public static void ReadSerializableList(this IStream stream, ref List<ISerializable> list, Func<ISerializable> constructor)
		{
			if (list == null)
			{
				list = stream.ReadSerializableList(constructor);
			}
			else
			{
				list.Clear();
				int length = stream.ReadInt32();
				if (constructor != null)
				{
					for (int i = 0; i < length; i++)
					{
						ISerializable s = constructor();
						stream.ReadSerializable(s);
						list.Add(s);
					}
				}
			}
		}
	}
}