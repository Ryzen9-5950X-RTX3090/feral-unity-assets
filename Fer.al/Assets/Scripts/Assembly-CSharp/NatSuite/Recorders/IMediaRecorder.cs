using System;
using System.Threading.Tasks;

namespace NatSuite.Recorders
{
	public interface IMediaRecorder
	{
		ValueTuple<int, int> frameSize { get; }

		void CommitFrame<T>(T[] pixelBuffer, long timestamp) where T : struct;

		void CommitFrame(IntPtr nativeBuffer, long timestamp);

		void CommitSamples(float[] sampleBuffer, long timestamp);

		Task<string> FinishWriting();
	}
}
