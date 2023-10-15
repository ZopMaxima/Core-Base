// SerializableType.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   January 26, 2016

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zop.Serialization
{
	/// <summary>
	/// Purpose: A base class used to serialize an unknown implementation by type.
	/// </summary>
	public abstract class SerializableType : ISerializableType
	{
		// ////////////////////////////////////////////////////////////////////////// //
		/* ************************************************************************** */
		// ATTRIBUTES
		/* ************************************************************************** */
		// ////////////////////////////////////////////////////////////////////////// //

		#region Attributes

		/// <summary>
		/// Speed-comparer for types.
		/// </summary>
		public class TypeComparer : IEqualityComparer<Type>
		{
			public static readonly TypeComparer Instance = new TypeComparer();
			public bool Equals(Type one, Type two) { return (object)one == (object)two; }
			public int GetHashCode(Type type) { return type.GetHashCode(); }
		}

		// ////////////////////////////////// //
		/* ********************************** */
		// CONSTANT ATTRIBUTES
		/* ********************************** */
		// ////////////////////////////////// //

		private const int HASH_UNDEFINED = 0;
		private const int VERSION_UNDEFINED = -1;

		// ////////////////////////////////// //
		/* ********************************** */
		// PUBLIC ATTRIBUTES
		/* ********************************** */
		// ////////////////////////////////// //

		public int TypeHash { get; private set; }

		public virtual string Identifier { get { return TypeHash.ToString(); } }
		public virtual int Version { get { return VERSION_UNDEFINED; } set { /* DO NOTHING */ } }

		// ////////////////////////////////// //
		/* ********************************** */
		// PRIVATE ATTRIBUTES
		/* ********************************** */
		// ////////////////////////////////// //

		private static readonly Dictionary<Type, int> _hash = new Dictionary<Type, int>(TypeComparer.Instance);
		private static readonly Dictionary<int, Type> _type = new Dictionary<int, Type>();

		#endregion

		// ////////////////////////////////////////////////////////////////////////// //
		/* ************************************************************************** */
		// CONSTRUCTORS
		/* ************************************************************************** */
		// ////////////////////////////////////////////////////////////////////////// //

		#region Constructors

		/// <summary>
		/// Static constructor assigns dictionaries for serializers.
		/// </summary>
		static SerializableType()
		{
			Type baseType = typeof(SerializableType);
			Type interfaceType = typeof(ISerializableType);
			Type[] types = baseType.Assembly.GetExportedTypes();

			// Match
			List<Type> matches = new List<Type>();
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i].IsSubclassOf(baseType) || interfaceType.IsAssignableFrom(types[i]))
				{
					matches.Add(types[i]);
				}
			}

			// Cache
			for (int i = 0; i < matches.Count; i++)
			{
				int hash = GetHashCode(matches[i]);
				Type type = matches[i];
				_type.Add(hash, type);
				_hash.Add(type, hash);
			}
		}

		/// <summary>
		/// Default constructor assigns a hash shortcut.
		/// </summary>
		public SerializableType()
		{
			TypeHash = SerializableType.HashOfType(GetType());
		}

		#endregion

		// ////////////////////////////////////////////////////////////////////////// //
		/* ************************************************************************** */
		// METHODS
		/* ************************************************************************** */
		// ////////////////////////////////////////////////////////////////////////// //

		#region Methods

		/// <summary>
		/// Returns the cached hash for this type.
		/// </summary>
		public static int HashOfType(Type type)
		{
			int hash;
			if (_hash.TryGetValue(type, out hash))
			{
				return hash;
			}
			else
			{
				return HASH_UNDEFINED;
			}
		}

		/// <summary>
		/// Returns the cached type for this hash.
		/// </summary>
		public static Type TypeOfHash(int hash)
		{
			Type type;
			if (_type.TryGetValue(hash, out type))
			{
				return type;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Returns true if this type matches the other.
		/// </summary>
		public bool IsHashOf(ISerializableType type)
		{
			return type != null && type.TypeHash == TypeHash;
		}

		/// <summary>
		/// Instantiate an object from a type hash.
		/// </summary>
		public static T Instantiate<T>(int hash) where T : class, ISerializableType
		{
			T type = null;

			// Read
			if (hash != HASH_UNDEFINED)
			{
				try
				{
					type = Activator.CreateInstance(_type[hash]) as T;
				}
				catch (Exception e)
				{
					Debug.LogException(e);
				}
			}

			// Return
			return type;
		}

		/// <summary>
		/// Write this type and its serializable data to a bit stream.
		/// </summary>
		public static void SerializeType(IStream stream, ISerializableType type)
		{
			if (type == null)
			{
				stream.WriteInt32(HASH_UNDEFINED);
			}
			else
			{
				stream.WriteInt32(type.TypeHash);
				stream.WriteInt32(type.Version);
				stream.WriteSerializable(type);
			}
		}

		/// <summary>
		/// Read this type and its serializable data from a bit stream.
		/// </summary>
		public static ISerializableType DeserializeType(IStream stream)
		{
			ISerializableType type = null;

			// Read
			int hash = stream.ReadInt32();
			if (hash != HASH_UNDEFINED)
			{
				int version = stream.ReadInt32();
				type = Instantiate<ISerializableType>(hash);
				if (type != null)
				{
					type.Version = version;
					type = stream.ReadSerializable(type) as ISerializableType;
				}
			}

			// Return
			return type;
		}

		/// <summary>
		/// Read this type and its serializable data from a bit stream.
		/// 
		/// The return type may be defined in this overload to reduce casting.
		/// </summary>
		public static T DeserializeType<T>(IStream stream) where T : class, ISerializableType, new()
		{
			T type = null;

			// Read
			int hash = stream.ReadInt32();
			if (hash != HASH_UNDEFINED)
			{
				int version = stream.ReadInt32();
				type = Instantiate<T>(hash);
				if (type != null)
				{
					type.Version = version;
					type = stream.ReadSerializable(type) as T;
				}
			}

			// Return
			return type;
		}

		/// <summary>
		/// Read this type and its serializable data from a bit stream.
		/// 
		/// The return type may be defined in this overload to reduce casting.
		/// </summary>
		public static T DeserializeStruct<T>(IStream stream) where T : struct, ISerializableType
		{
			T type = default;

			// Read
			int hash = stream.ReadInt32();
			if (hash != HASH_UNDEFINED)
			{
				int version = stream.ReadInt32();
				type.Version = version;
				type = (T)stream.ReadSerializable(type);
			}

			// Return
			return type;
		}

		/// <summary>
		/// Write data to a bit stream.
		/// </summary>
		public abstract void Serialize(IStream stream);

		/// <summary>
		/// Read data from a bit stream.
		/// </summary>
        public abstract void Deserialize(IStream stream);

		/// <summary>
		/// Returns a hash code for the specified type.
		/// </summary>
		private static int GetHashCode(Type type)
		{
			if (type != null)
			{
				string name = type.FullName;
				int hash = HASH_UNDEFINED;

				// Mash it up.
				for (int i = 0; i < name.Length; i++)
				{
					// Shift by up-to 25 because the class name is likely chars from 60-120.
					int mod = i % 25;
					int letter = (int)name[i];
					hash ^= letter << mod;
				}

				// Return
				return hash;
			}
			else
			{
				return HASH_UNDEFINED;
			}
		}

		#endregion
	}
}