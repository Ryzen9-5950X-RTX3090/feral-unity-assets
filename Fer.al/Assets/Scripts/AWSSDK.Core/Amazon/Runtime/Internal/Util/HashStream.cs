using System.IO;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public abstract class HashStream : WrapperStream
	{
		protected IHashingWrapper Algorithm
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool FinishedHashing
		{
			get
			{
				return default(bool);
			}
		}

		protected long CurrentPosition
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte[] CalculatedHash
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public byte[] ExpectedHash
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long ExpectedLength
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public override bool CanSeek
		{
			get
			{
				return default(bool);
			}
		}

		public override long Position
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public override long Length
		{
			get
			{
				return default(long);
			}
		}

		protected HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override void Close()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public virtual void CalculateHash()
		{
		}

		public void Reset()
		{
		}

		private void ValidateBaseStream()
		{
		}

		protected static bool CompareHashes(byte[] expected, byte[] actual)
		{
			return default(bool);
		}
	}
}
