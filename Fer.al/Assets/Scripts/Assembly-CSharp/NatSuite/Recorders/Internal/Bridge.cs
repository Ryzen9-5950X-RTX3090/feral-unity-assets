using System;

namespace NatSuite.Recorders.Internal
{
	public static class Bridge
	{
		public delegate void RecordingHandler(IntPtr context, IntPtr path);

		private const string Assembly = "NatCorder";

		public static extern IntPtr CreateMP4Recorder(int width, int height, float framerate, int bitrate, int keyframeInterval, int sampleRate, int channelCount, string recordingPath, RecordingHandler callback, IntPtr context);

		public static extern IntPtr CreateHEVCRecorder(int width, int height, float framerate, int bitrate, int keyframeInterval, int sampleRate, int channelCount, string recordingPath, RecordingHandler callback, IntPtr context);

		public static extern IntPtr CreateGIFRecorder(int width, int height, float frameDuration, string recordingPath, RecordingHandler callback, IntPtr context);

		public static extern void FrameSize(this IntPtr recorder, out int width, out int height);

		public static extern void CommitFrame(this IntPtr recorder, IntPtr pixelBuffer, long timestamp);

		public static extern void CommitSamples(this IntPtr recorder, float[] sampleBuffer, int sampleCount, long timestamp);

		public static extern void FinishWriting(this IntPtr recorder);
	}
}
