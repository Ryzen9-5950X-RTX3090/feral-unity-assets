using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NatSuite.Recorders
{
	public sealed class GIFRecorder : IMediaRecorder
	{
		private readonly IMediaRecorder recorder;

		public ValueTuple<int, int> frameSize
		{
			get
			{
				return default(ValueTuple<int, int>);
			}
		}

		public GIFRecorder(int width, int height, float frameDuration)
		{
		}

		public void CommitFrame<T>(T[] pixelBuffer, long timestamp = 0L) where T : struct
		{
		}

		public void CommitFrame(IntPtr nativeBuffer, long timestamp = 0L)
		{
		}

		public void CommitSamples([Optional] float[] sampleBuffer, long timestamp = 0L)
		{
		}

		public Task<string> FinishWriting()
		{
			return null;
		}
	}
}
