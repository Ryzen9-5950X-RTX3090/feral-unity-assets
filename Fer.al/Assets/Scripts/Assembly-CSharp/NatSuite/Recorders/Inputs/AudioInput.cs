using System;
using NatSuite.Recorders.Clocks;
using UnityEngine;

namespace NatSuite.Recorders.Inputs
{
	public sealed class AudioInput : IDisposable
	{
		private class AudioInputAttachment : UnityEngine.MonoBehaviour
		{
			public Action<float[]> sampleBufferDelegate;

			private void OnAudioFilterRead(float[] data, int channels)
			{
			}
		}

		private readonly IMediaRecorder recorder;

		private readonly IClock clock;

		private readonly AudioInputAttachment attachment;

		private readonly bool mute;

		public AudioInput(IMediaRecorder recorder, IClock clock, AudioListener audioListener)
		{
		}

		public AudioInput(IMediaRecorder recorder, IClock clock, AudioSource audioSource, bool mute = false)
		{
		}

		public void Dispose()
		{
		}

		private AudioInput(IMediaRecorder recorder, IClock clock, GameObject gameObject, bool mute = false)
		{
		}

		private void OnSampleBuffer(float[] data)
		{
		}
	}
}
