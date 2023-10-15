// SerializableStream.cs
// 
// Author: Max Jackman
// Email:  max.jackman@outlook.com
// Date:   October 10, 2022

using System;
using System.IO;
using UnityEngine;

namespace Zop.Serialization
{
	/// <summary>
	/// A simplified stream wrapper.
	/// </summary>
	public class SerializableStream : IStream
	{
		private MemoryStream _stream;
		private BinaryReader _reader;
		private BinaryWriter _writer;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SerializableStream()
		{
			_stream = new MemoryStream();
			_reader = new BinaryReader(_stream);
			_writer = new BinaryWriter(_stream);
		}

		/// <summary>
		/// Construct with capacity.
		/// </summary>
		public SerializableStream(int capacity)
		{
			_stream = new MemoryStream(capacity);
			_reader = new BinaryReader(_stream);
			_writer = new BinaryWriter(_stream);
		}

		/// <summary>
		/// Construct with data.
		/// </summary>
		public SerializableStream(byte[] data)
		{
			_stream = new MemoryStream(data);
			_reader = new BinaryReader(_stream);
			_writer = new BinaryWriter(_stream);
		}

		/// <summary>
		/// Write data to the stream.
		/// </summary>
		public void Serialize(IStream stream)
		{
			stream.WriteBuffer(_stream.ToArray());
		}

		/// <summary>
		/// Read data from the stream.
		/// </summary>
		public void Deserialize(IStream stream)
		{
			_writer.Write(stream.ReadBuffer());
			_stream.Seek(0, SeekOrigin.Begin);
		}

		/// <summary>
		/// Return the byte data of this stream.
		/// </summary>
		public byte[] GetBytes()
		{
			return _stream.ToArray();
		}

		public void WriteBoolean(bool value) { _writer.Write(value); }
		public void WriteSByte(sbyte value) { _writer.Write(value); }
		public void WriteInt16(short value) { _writer.Write(value); }
		public void WriteInt32(int value) { _writer.Write(value); }
		public void WriteInt64(long value) { _writer.Write(value); }
		public void WriteByte(byte value) { _writer.Write(value); }
		public void WriteUInt16(ushort value) { _writer.Write(value); }
		public void WriteUInt32(uint value) { _writer.Write(value); }
		public void WriteUInt64(ulong value) { _writer.Write(value); }
		public void WriteSingle(float value) { _writer.Write(value); }
		public void WriteDouble(double value) { _writer.Write(value); }
		public void WriteDecimal(decimal value) { _writer.Write(value); }
		public void WriteChar(char value) { _writer.Write((ushort)value); }
		public void WriteString(string value) { bool hasValue = value != null; _writer.Write(hasValue); if (hasValue) { _writer.Write(value); } }
		public void WriteVector2(Vector2 value) { _writer.Write(value.x); _writer.Write(value.y); }
		public void WriteVector3(Vector3 value) { _writer.Write(value.x); _writer.Write(value.y); _writer.Write(value.z); }
		public void WriteVector4(Vector4 value) { _writer.Write(value.x); _writer.Write(value.y); _writer.Write(value.z); _writer.Write(value.w); }
		public void WriteQuaternion(Quaternion value) { _writer.Write(value.x); _writer.Write(value.y); _writer.Write(value.z); _writer.Write(value.w); }
		public void WriteColor(Color value) { _writer.Write((byte)(value.r * 255)); _writer.Write((byte)(value.g * 255)); _writer.Write((byte)(value.b * 255)); _writer.Write((byte)(value.a * 255)); }
		public void WriteDateTime(DateTime value) { _writer.Write(value.ToBinary()); }
		public void WriteStream(IStream value) { bool hasValue = value != null; _writer.Write(hasValue); if (hasValue) { value.Serialize(this); } }
		public void WriteSerializable(ISerializable value) { bool hasValue = value != null; _writer.Write(hasValue); if (hasValue) { value.Serialize(this); } }
		public void WriteBuffer(byte[] value) { if (value != null) { _writer.Write(value.Length); _writer.Write(value); } else { _writer.Write(-1); } }
		public void WriteBuffer(byte[] value, int index) { if (value != null) { _writer.Write(value.Length - index); _writer.Write(value, index, value.Length - index); } else { _writer.Write(-1); } }
		public void WriteBuffer(byte[] value, int index, int length) { if (value != null) { _writer.Write(length); _writer.Write(value, index, length); } else { _writer.Write(-1); } }

		public bool ReadBoolean() { return _reader.ReadBoolean(); }
		public sbyte ReadSByte() { return _reader.ReadSByte(); }
		public short ReadInt16() { return _reader.ReadInt16(); }
		public int ReadInt32() { return _reader.ReadInt32(); }
		public long ReadInt64() { return _reader.ReadInt64(); }
		public byte ReadByte() { return _reader.ReadByte(); }
		public ushort ReadUInt16() { return _reader.ReadUInt16(); }
		public uint ReadUInt32() { return _reader.ReadUInt32(); }
		public ulong ReadUInt64() { return _reader.ReadUInt64(); }
		public float ReadSingle() { return _reader.ReadSingle(); }
		public double ReadDouble() { return _reader.ReadDouble(); }
		public decimal ReadDecimal() { return _reader.ReadDecimal(); }
		public char ReadChar() { return _reader.ReadChar(); }
		public string ReadString() { if (_reader.ReadBoolean()) { return _reader.ReadString(); } else { return null; } }
		public Vector2 ReadVector2() { return new Vector2(_reader.ReadSingle(), _reader.ReadSingle()); }
		public Vector3 ReadVector3() { return new Vector3(_reader.ReadSingle(), _reader.ReadSingle(), _reader.ReadSingle()); }
		public Vector4 ReadVector4() { return new Vector4(_reader.ReadSingle(), _reader.ReadSingle(), _reader.ReadSingle(), _reader.ReadSingle()); }
		public Quaternion ReadQuaternion() { return new Quaternion(_reader.ReadSingle(), _reader.ReadSingle(), _reader.ReadSingle(), _reader.ReadSingle()); }
		public Color ReadColor() { return new Color(_reader.ReadByte() / 255.0f, _reader.ReadByte() / 255.0f, _reader.ReadByte() / 255.0f, _reader.ReadByte() / 255.0f); }
		public DateTime ReadDateTime() { return DateTime.FromBinary(_reader.ReadInt64()); }
		public IStream ReadStream() { if (_reader.ReadBoolean()) { IStream stream = new SerializableStream(); stream.Deserialize(this); return stream; } else { return null; } }
		public ISerializable ReadSerializable(ISerializable instance) { if (_reader.ReadBoolean()) { instance.Deserialize(this); return instance; } else { return null; } }
		public byte[] ReadBuffer() { int length = _reader.ReadInt32(); if (length >= 0) { return _reader.ReadBytes(length); } else { return null; } }

		/// <summary>
		/// Dispose of internal disposables.
		/// </summary>
		public void Dispose()
		{
			if (_stream != null)
			{
				_stream.Dispose();
				_stream = null;
			}
			if (_reader != null)
			{
				_reader.Dispose();
				_reader = null;
			}
			if (_writer != null)
			{
				_writer.Dispose();
				_writer = null;
			}
		}
	}
}