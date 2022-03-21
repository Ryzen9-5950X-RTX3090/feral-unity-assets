using UnityEngine;

namespace Crosstales.Common.Util
{
	public class FFTAnalyzer : MonoBehaviour
	{
		[Tooltip("Array for the samples. More samples mean better accuracy but it also needs more performance (default: 256)")]
		public float[] Samples;

		[Tooltip("Analyzed channel (0 = right, 1 = left, default: 0).")]
		[Range(0f, 1f)]
		public int Channel;

		[Tooltip("FFT-algorithm to analyze the audio (default: BlackmanHarris).")]
		public FFTWindow FFTMode;

		public void Update()
		{
		}
	}
}
