using System;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[PostProcess(typeof(ScreenSpaceReflectionsRenderer), "Unity/Screen-space reflections", true)]
	public sealed class ScreenSpaceReflections : PostProcessEffectSettings
	{
		[Tooltip("Choose a quality preset, or use \"Custom\" to create your own custom preset. Don't use a preset higher than \"Medium\" if you desire good performance on consoles.")]
		public ScreenSpaceReflectionPresetParameter preset;

		[Range(0f, 256f)]
		[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
		public IntParameter maximumIterationCount;

		[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
		public ScreenSpaceReflectionResolutionParameter resolution;

		[Range(1f, 64f)]
		[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
		public FloatParameter thickness;

		[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
		public FloatParameter maximumMarchDistance;

		[Range(0f, 1f)]
		[Tooltip("Fades reflections close to the near planes.")]
		public FloatParameter distanceFade;

		[Range(0f, 1f)]
		[Tooltip("Fades reflections close to the screen edges.")]
		public FloatParameter vignette;

		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}
	}
}
