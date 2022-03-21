using System;
using System.Threading.Tasks;

namespace NatSuite.Recorders
{
	public sealed class MP4Recorder : IMediaRecorder
	{
		private readonly IMediaRecorder recorder;

		public ValueTuple<int, int> frameSize
		{
			get
			{
				return default(ValueTuple<int, int>);
			}
		}

		public MP4Recorder(int width, int height, float frameRate, int sampleRate = 0, int channelCount = 0, int bitrate = 5909760, int keyframeInterval = 3)
		{
		}

		public void CommitFrame<T>(T[] pixelBuffer, long timestamp) where T : struct
		{
		}

		public void CommitFrame(IntPtr nativeBuffer, long timestamp)
		{
		}

		public void CommitSamples(float[] sampleBuffer, long timestamp)
		{
		}

		public Task<string> FinishWriting()
		{
			return null;
		}
	}
}
