using System;
using System.Threading.Tasks;
using AOT;

namespace NatSuite.Recorders.Internal
{
	public sealed class NativeRecorder : IMediaRecorder
	{
		private readonly IntPtr recorder;

		private readonly TaskCompletionSource<string> recordingTask;

		public ValueTuple<int, int> frameSize
		{
			get
			{
				return default(ValueTuple<int, int>);
			}
		}

		public NativeRecorder(Func<Bridge.RecordingHandler, IntPtr, IntPtr> recorderCreator)
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

		[MonoPInvokeCallback(typeof(Bridge.RecordingHandler))]
		private static void OnRecording(IntPtr context, IntPtr path)
		{
		}
	}
}
