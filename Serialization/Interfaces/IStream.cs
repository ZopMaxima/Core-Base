// IStream.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using UnityEngine;

namespace Zop.Serialization
{
	/// <summary>
	/// The read / write interface of a stream.
	/// </summary>
	public interface IStream : ISerializable, IDisposable
	{
		/// <summary>
		/// Return the byte data of this stream.
		/// </summary>
		byte[] GetBytes();

		void WriteBoolean(bool value);
		void WriteSByte(sbyte value);
		void WriteInt16(short value);
		void WriteInt32(int value);
		void WriteInt64(long value);
		void WriteByte(byte value);
		void WriteUInt16(ushort value);
		void WriteUInt32(uint value);
		void WriteUInt64(ulong value);
		void WriteSingle(float value);
		void WriteDouble(double value);
		void WriteDecimal(decimal value);
		void WriteChar(char value);
		void WriteString(string value);
		void WriteVector2(Vector2 value);
		void WriteVector3(Vector3 value);
		void WriteVector4(Vector4 value);
		void WriteQuaternion(Quaternion value);
		void WriteColor(Color value);
		void WriteDateTime(DateTime value);
		void WriteStream(IStream value);
		void WriteSerializable(ISerializable value);
		void WriteBuffer(byte[] value);
		void WriteBuffer(byte[] value, int index);
		void WriteBuffer(byte[] value, int index, int length);

		bool ReadBoolean();
		sbyte ReadSByte();
		short ReadInt16();
		int ReadInt32();
		long ReadInt64();
		byte ReadByte();
		ushort ReadUInt16();
		uint ReadUInt32();
		ulong ReadUInt64();
		float ReadSingle();
		double ReadDouble();
		decimal ReadDecimal();
		char ReadChar();
		string ReadString();
		Vector2 ReadVector2();
		Vector3 ReadVector3();
		Vector4 ReadVector4();
		Quaternion ReadQuaternion();
		Color ReadColor();
		DateTime ReadDateTime();
		IStream ReadStream();
		ISerializable ReadSerializable(ISerializable instance);
		byte[] ReadBuffer();
	}
}