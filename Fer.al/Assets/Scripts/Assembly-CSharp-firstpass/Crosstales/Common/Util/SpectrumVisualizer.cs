using UnityEngine;

namespace Crosstales.Common.Util
{
	public class SpectrumVisualizer : MonoBehaviour
	{
		[Tooltip("FFT-analyzer with the spectrum data.")]
		public FFTAnalyzer Analyzer;

		[Tooltip("Prefab for the frequency representation.")]
		public GameObject VisualPrefab;

		[Tooltip("Width per prefab.")]
		public float Width;

		[Tooltip("Gain-power for the frequency.")]
		public float Gain;

		[Tooltip("Frequency band from left-to-right (default: true).")]
		public bool LeftToRight;

		[Tooltip("Opacity of the material of the prefab (default: 1).")]
		[Range(0f, 1f)]
		public float Opacity;

		private Transform tf;

		private Transform[] visualTransforms;

		private Vector3 visualPos;

		private int samplesPerChannel;

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
