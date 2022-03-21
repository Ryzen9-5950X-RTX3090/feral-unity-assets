using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Connections.HTTP2
{
	internal abstract class CommonFrameView : IFrameDataView, IDisposable
	{
		protected List<HTTP2FrameHeaderAndPayload> frames;

		protected int currentFrameIdx;

		protected byte[] data;

		protected uint dataOffset;

		protected uint maxOffset;

		public long Length
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

		public long Position
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

		public abstract void AddFrame(HTTP2FrameHeaderAndPayload frame);

		protected abstract long CalculateDataLengthForFrame(HTTP2FrameHeaderAndPayload frame);

		public virtual int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public virtual int ReadByte()
		{
			return default(int);
		}

		protected abstract bool AdvanceFrame();

		public virtual void Dispose()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
