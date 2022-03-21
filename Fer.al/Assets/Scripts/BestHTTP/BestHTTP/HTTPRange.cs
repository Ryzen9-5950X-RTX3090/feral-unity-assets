using System.Runtime.CompilerServices;

namespace BestHTTP
{
	public sealed class HTTPRange
	{
		public long FirstBytePos
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

		public long LastBytePos
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

		public long ContentLength
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

		public bool IsValid
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal HTTPRange()
		{
		}

		internal HTTPRange(int contentLength)
		{
		}

		internal HTTPRange(long firstBytePosition, long lastBytePosition, long contentLength)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
