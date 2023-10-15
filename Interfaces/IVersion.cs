// IVersion.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 14, 2022

namespace Zop
{
	/// <summary>
	/// Allows an object to display a change of state to its observers.
	/// </summary>
	public interface IVersion<T>
	{
		/// <summary>
		/// Returns true if this object has an initialized version.
		/// </summary>
		bool HasVersion { get; }

		/// <summary>
		/// Returns the object's version.
		/// </summary>
		T Version { get; }

		/// <summary>
		/// Increment the object's version.
		/// </summary>
		void NextVersion();
	}
}