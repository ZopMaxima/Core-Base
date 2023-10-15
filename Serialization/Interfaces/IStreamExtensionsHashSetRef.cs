// IStreamExtensionsHashSetRef.cs
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
	public static class IStreamExtensionsHashSetRef
	{
		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadBooleanHashSet(this IStream stream, ref HashSet<bool> set)
		{
			if (set == null)
			{
				set = stream.ReadBooleanHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadBoolean());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadSByteHashSet(this IStream stream, ref HashSet<sbyte> set)
		{
			if (set == null)
			{
				set = stream.ReadSByteHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadSByte());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadInt16HashSet(this IStream stream, ref HashSet<short> set)
		{
			if (set == null)
			{
				set = stream.ReadInt16HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadInt16());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadInt32HashSet(this IStream stream, ref HashSet<int> set)
		{
			if (set == null)
			{
				set = stream.ReadInt32HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadInt32());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadInt64HashSet(this IStream stream, ref HashSet<long> set)
		{
			if (set == null)
			{
				set = stream.ReadInt64HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadInt64());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadByteHashSet(this IStream stream, ref HashSet<byte> set)
		{
			if (set == null)
			{
				set = stream.ReadByteHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadByte());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadUInt16HashSet(this IStream stream, ref HashSet<ushort> set)
		{
			if (set == null)
			{
				set = stream.ReadUInt16HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadUInt16());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadUInt32HashSet(this IStream stream, ref HashSet<uint> set)
		{
			if (set == null)
			{
				set = stream.ReadUInt32HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadUInt32());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadUInt64HashSet(this IStream stream, ref HashSet<ulong> set)
		{
			if (set == null)
			{
				set = stream.ReadUInt64HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadUInt64());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadSingleHashSet(this IStream stream, ref HashSet<float> set)
		{
			if (set == null)
			{
				set = stream.ReadSingleHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadSingle());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadDoubleHashSet(this IStream stream, ref HashSet<double> set)
		{
			if (set == null)
			{
				set = stream.ReadDoubleHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadDouble());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadDecimalHashSet(this IStream stream, ref HashSet<decimal> set)
		{
			if (set == null)
			{
				set = stream.ReadDecimalHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadDecimal());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadCharHashSet(this IStream stream, ref HashSet<char> set)
		{
			if (set == null)
			{
				set = stream.ReadCharHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadChar());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadStringHashSet(this IStream stream, ref HashSet<string> set)
		{
			if (set == null)
			{
				set = stream.ReadStringHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadString());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadVector2HashSet(this IStream stream, ref HashSet<Vector2> set)
		{
			if (set == null)
			{
				set = stream.ReadVector2HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadVector2());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadVector3HashSet(this IStream stream, ref HashSet<Vector3> set)
		{
			if (set == null)
			{
				set = stream.ReadVector3HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadVector3());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadVector4HashSet(this IStream stream, ref HashSet<Vector4> set)
		{
			if (set == null)
			{
				set = stream.ReadVector4HashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadVector4());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadQuaternionHashSet(this IStream stream, ref HashSet<Quaternion> set)
		{
			if (set == null)
			{
				set = stream.ReadQuaternionHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadQuaternion());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadColorHashSet(this IStream stream, ref HashSet<Color> set)
		{
			if (set == null)
			{
				set = stream.ReadColorHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadColor());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadDateTimeHashSet(this IStream stream, ref HashSet<DateTime> set)
		{
			if (set == null)
			{
				set = stream.ReadDateTimeHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadDateTime());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadStreamHashSet(this IStream stream, ref HashSet<IStream> set)
		{
			if (set == null)
			{
				set = stream.ReadStreamHashSet();
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				for (int i = 0; i < length; i++)
				{
					set.Add(stream.ReadStream());
				}
			}
		}

		/// <summary>
		/// Read a set of values.
		/// </summary>
		public static void ReadSerializableHashSet(this IStream stream, ref HashSet<ISerializable> set, Func<ISerializable> constructor)
		{
			if (set == null)
			{
				set = stream.ReadSerializableHashSet(constructor);
			}
			else
			{
				set.Clear();
				int length = stream.ReadInt32();
				if (constructor != null)
				{
					for (int i = 0; i < length; i++)
					{
						ISerializable s = constructor();
						stream.ReadSerializable(s);
						set.Add(s);
					}
				}
			}
		}
	}
}