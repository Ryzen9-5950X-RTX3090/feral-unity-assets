using System;
using System.Collections;
using System.Runtime.CompilerServices;
using NatSuite.Recorders.Clocks;
using UnityEngine;

namespace NatSuite.Recorders.Inputs
{
	public sealed class CameraInput : IDisposable
	{
		private sealed class CameraInputAttachment : UnityEngine.MonoBehaviour
		{
		}

		public int frameSkip;

		private readonly IMediaRecorder recorder;

		private readonly IClock clock;

		private readonly Camera[] cameras;

		private readonly RenderTextureDescriptor frameDescriptor;

		private readonly Texture2D readbackBuffer;

		private readonly CameraInputAttachment attachment;

		private byte[] pixelBuffer;

		private int frameCount;

		public CameraInput(IMediaRecorder recorder, IClock clock, Camera[] cameras)
		{
		}

		public void Dispose()
		{
		}

		[IteratorStateMachine(typeof(<OnFrame>d__11))]
		private IEnumerator OnFrame()
		{
			return null;
		}
	}
}
