using System;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class NativeRingBuffer : IDisposable
	{
		private readonly NativeBuffer BrhnIpAksXpIZLaJirMAeckHzoH;

		private readonly int LHcUXOytTkIjlqPoenVhkyCFGKR;

		private long iIQOLmrxIqgQeeJJxBEGylnjpIn;

		private long jhIWPqGqHLYlEiNUNDFHTHAGxQl;

		private int zwpbwCXlbrFscKiFvhUnngSxoZTD;

		private bool DSiEclHKneQNlzttRUUgAHdLEvu;

		private uint EfoBwbBBneQRbruICOLmvonLpdVg;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public int Capacity
		{
			get
			{
				return default(int);
			}
		}

		public int BytesInBuffer
		{
			get
			{
				return default(int);
			}
		}

		public bool BufferOverrun
		{
			get
			{
				return default(bool);
			}
		}

		public NativeRingBuffer(int capacity)
		{
		}

		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite, out int startOffset, out uint passId)
		{
			return default(int);
		}

		public int Write(byte[] buffer, int numBytesToWrite, out int startOffset, out uint passId)
		{
			return default(int);
		}

		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite)
		{
			return default(int);
		}

		public int Write(byte[] buffer, int numBytesToWrite)
		{
			return default(int);
		}

		public int Read(IntPtr buffer, int bufferLength, int numBytesToRead)
		{
			return default(int);
		}

		public int Read(byte[] buffer, int numBytesToRead)
		{
			return default(int);
		}

		public int RandomRead(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex)
		{
			return default(int);
		}

		public int RandomRead(byte[] buffer, int numBytesToRead, int readStartIndex)
		{
			return default(int);
		}

		public bool IsValid(int startIndex, uint passId)
		{
			return default(bool);
		}

		public void Reset()
		{
		}

		private void PJeaLDkSvEGgSidNDJuPcdEagVYk(int P_0)
		{
		}

		private void vyefEeRiQmmuqmZyLiHzaxpvULX(int P_0)
		{
		}

		private void rcOGaiRvvpUuVagAdKqrDEsIdIC()
		{
		}

		public void Dispose()
		{
		}

		~NativeRingBuffer()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
