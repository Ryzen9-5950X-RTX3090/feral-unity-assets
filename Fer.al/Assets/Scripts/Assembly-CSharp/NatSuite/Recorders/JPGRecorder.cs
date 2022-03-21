using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace NatSuite.Recorders
{
	public sealed class JPGRecorder : IMediaRecorder
	{
		private readonly Texture2D framebuffer;

		private readonly string recordingPath;

		private readonly List<Task> writeTasks;

		private int frameCount;

		public ValueTuple<int, int> frameSize
		{
			get
			{
				return default(ValueTuple<int, int>);
			}
		}

		public JPGRecorder(int imageWidth, int imageHeight)
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
