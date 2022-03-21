using System;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[PostProcess(typeof(BloomRenderer), "Unity/Bloom", true)]
	public sealed class Bloom : PostProcessEffectSettings
	{
		[Min(0f)]
		[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
		public FloatParameter intensity;

		[Min(0f)]
		[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
		public FloatParameter threshold;

		[Range(0f, 1f)]
		[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
		public FloatParameter softKnee;

		[Tooltip("Clamps pixels to control the bloom amount. Value is in gamma-space.")]
		public FloatParameter clamp;

		[Range(1f, 10f)]
		[Tooltip("Changes the extent of veiling effects. For maximum quality, use integer values. Because this value changes the internal iteration count, You should not animating it as it may introduce issues with the perceived radius.")]
		public FloatParameter diffusion;

		[Range(-1f, 1f)]
		[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
		public FloatParameter anamorphicRatio;

		[ColorUsage(false, true)]
		[Tooltip("Global tint of the bloom filter.")]
		public ColorParameter color;

		[FormerlySerializedAs("mobileOptimized")]
		[Tooltip("Boost performance by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
		public BoolParameter fastMode;

		[Tooltip("The lens dirt texture used to add smudges or dust to the bloom effect.")]
		[DisplayName("Texture")]
		public TextureParameter dirtTexture;

		[Min(0f)]
		[Tooltip("The intensity of the lens dirtiness.")]
		[DisplayName("Intensity")]
		public FloatParameter dirtIntensity;

		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}
	}
}
