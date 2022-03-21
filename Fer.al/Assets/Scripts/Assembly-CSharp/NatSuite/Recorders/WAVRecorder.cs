using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NatSuite.Recorders
{
	public sealed class WAVRecorder : IMediaRecorder
	{
		private readonly int sampleRate;

		private readonly int channelCount;

		private readonly FileStream stream;

		private int sampleCount;

		public ValueTuple<int, int> frameSize
		{
			get
			{
				return default(ValueTuple<int, int>);
			}
		}

		public WAVRecorder(int sampleRate, int channelCount)
		{
		}

		public void CommitFrame<T>([Optional] T[] pixelBuffer, long timestamp = 0L) where T : struct
		{
		}

		public void CommitFrame([Optional] IntPtr nativeBuffer, long timestamp = 0L)
		{
		}

		public void CommitSamples(float[] sampleBuffer, long timestamp = 0L)
		{
		}

		public Task<string> FinishWriting()
		{
			return null;
		}
	}
}
