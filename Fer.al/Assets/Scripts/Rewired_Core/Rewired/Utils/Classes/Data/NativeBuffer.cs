using System;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class NativeBuffer : IDisposable
	{
		private IntPtr czeeadyvGnEBPXiowfkWjdSLOfUG;

		private int CvHRPSyRdGHqbdRDaLvCUlxYDMo;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public IntPtr Pointer
		{
			get
			{
				return default(IntPtr);
			}
		}

		public int Length
		{
			get
			{
				return default(int);
			}
		}

		public byte this[int index]
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public NativeBuffer(int size)
		{
		}

		public IntPtr GetPointer(int offset = 0)
		{
			return default(IntPtr);
		}

		public string DumpToHexString()
		{
			return null;
		}

		public bool ReadBit(int byteIndex, byte bit)
		{
			return default(bool);
		}

		public byte ReadByte(int startIndex)
		{
			return default(byte);
		}

		public short ReadShort(int startIndex)
		{
			return default(short);
		}

		public ushort ReadUShort(int startIndex)
		{
			return default(ushort);
		}

		public int ReadInt(int startIndex)
		{
			return default(int);
		}

		public uint ReadUInt(int startIndex)
		{
			return default(uint);
		}

		public long ReadLong(int startIndex)
		{
			return default(long);
		}

		public ulong ReadULong(int startIndex)
		{
			return default(ulong);
		}

		public float ReadFloat(int startIndex)
		{
			return default(float);
		}

		public double ReadDouble(int startIndex)
		{
			return default(double);
		}

		public void Read(byte[] buffer, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0)
		{
		}

		public void Read(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0)
		{
		}

		public int TryReadBytes(byte[] buffer, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0)
		{
			return default(int);
		}

		public int TryReadBytes(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0)
		{
			return default(int);
		}

		public void WriteBit(int byteIndex, byte bit, bool value)
		{
		}

		public void Write(byte @byte, int startIndex)
		{
		}

		public void Write(short bytes, int startIndex)
		{
		}

		public void Write(ushort bytes, int startIndex)
		{
		}

		public void Write(int bytes, int startIndex)
		{
		}

		public void Write(uint bytes, int startIndex)
		{
		}

		public void Write(long bytes, int startIndex)
		{
		}

		public void Write(ulong bytes, int startIndex)
		{
		}

		public void Write(float bytes, int startIndex)
		{
		}

		public void Write(double bytes, int startIndex)
		{
		}

		public void Write(byte[] bytes, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0)
		{
		}

		public void Write(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0)
		{
		}

		public int TryWriteBytes(byte[] bytes, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0)
		{
			return default(int);
		}

		public int TryWriteBytes(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0)
		{
			return default(int);
		}

		public bool Resize(int size, bool preserveData)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public void Release()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void Dispose()
		{
		}

		~NativeBuffer()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public static implicit operator IntPtr(NativeBuffer buffer)
		{
			return default(IntPtr);
		}

		public static bool Copy(NativeBuffer source, NativeBuffer destination)
		{
			return default(bool);
		}
	}
}
