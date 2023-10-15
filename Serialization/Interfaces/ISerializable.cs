// ISerializable.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   June 2, 2021

namespace Zop.Serialization
{
	/// <summary>
	/// A serializable object.
	/// </summary>
	public interface ISerializable
	{
		/// <summary>
		/// Write data to the stream.
		/// </summary>
		void Serialize(IStream stream);

		/// <summary>
		/// Read data from the stream.
		/// </summary>
		void Deserialize(IStream stream);
	}
}