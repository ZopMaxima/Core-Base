// ISerializableType.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   January 26, 2016

namespace Zop.Serialization
{
	/// <summary>
	/// Purpose: An interface used to serialize an unknown implementation by type.
	/// </summary>
	public interface ISerializableType : ISerializable
	{
		int TypeHash { get; }
		int Version { get; set; }

		/// <summary>
		/// Returns true if this type matches the other.
		/// </summary>
		bool IsHashOf(ISerializableType type);
	}
}