using System;
using UnityEngine;

namespace BeautifyEffect
{
	[CreateAssetMenu]
	public class BeautifyProfile : ScriptableObject
	{
		[Range(0f, 0.2f)]
		public float dither;

		[Range(0f, 1f)]
		public float ditherDepth;

		[Range(0f, 1f)]
		public float sharpenMinDepth;

		[Range(0f, 1.1f)]
		public float sharpenMaxDepth;

		[Range(0f, 15f)]
		public float sharpen;

		[Range(0f, 0.05f)]
		public float sharpenDepthThreshold;

		public Color tintColor;

		[Range(0f, 0.2f)]
		public float sharpenRelaxation;

		[Range(0f, 1f)]
		public float sharpenClamp;

		[Range(0f, 1f)]
		public float sharpenMotionSensibility;

		[Range(0f, 20f)]
		public float antialiasStrength;

		[Range(0f, 0.05f)]
		public float antialiasDepthThreshold;

		public float saturate;

		[Range(0.5f, 1.5f)]
		public float contrast;

		public float brightness;

		public float daltonize;

		public bool vignetting;

		public Color vignettingColor;

		public float vignettingFade;

		public bool vignettingCircularShape;

		public float vignettingAspectRatio;

		[Range(0f, 1f)]
		public float vignettingBlink;

		public Texture2D vignettingMask;

		public bool frame;

		public Color frameColor;

		public Texture2D frameMask;

		public bool lut;

		[Range(0f, 1f)]
		public float lutIntensity;

		public Texture2D lutTexture;

		public bool nightVision;

		public Color nightVisionColor;

		public bool outline;

		public Color outlineColor;

		public bool thermalVision;

		public bool lensDirt;

		[Range(0f, 1f)]
		public float lensDirtThreshold;

		[Range(0f, 1f)]
		public float lensDirtIntensity;

		public Texture2D lensDirtTexture;

		public bool bloom;

		public LayerMask bloomCullingMask;

		[Range(1f, 4f)]
		public float bloomLayerMaskDownsampling;

		[Range(0f, 10f)]
		public float bloomIntensity;

		public float bloomMaxBrightness;

		[Range(0f, 3f)]
		public float bloomBoost0;

		[Range(0f, 3f)]
		public float bloomBoost1;

		[Range(0f, 3f)]
		public float bloomBoost2;

		[Range(0f, 3f)]
		public float bloomBoost3;

		[Range(0f, 3f)]
		public float bloomBoost4;

		[Range(0f, 3f)]
		public float bloomBoost5;

		public bool bloomAntiflicker;

		public bool bloomUltra;

		[Range(0f, 5f)]
		public float bloomThreshold;

		public bool bloomCustomize;

		[Range(0f, 1f)]
		public float bloomWeight0;

		[Range(0f, 1f)]
		public float bloomWeight1;

		[Range(0f, 1f)]
		public float bloomWeight2;

		[Range(0f, 1f)]
		public float bloomWeight3;

		[Range(0f, 1f)]
		public float bloomWeight4;

		[Range(0f, 1f)]
		public float bloomWeight5;

		public bool bloomBlur;

		[Range(0f, 1f)]
		public float bloomDepthAtten;

		[Range(-1f, 1f)]
		public float bloomLayerZBias;

		public bool anamorphicFlares;

		[Range(0f, 10f)]
		public float anamorphicFlaresIntensity;

		public bool anamorphicFlaresAntiflicker;

		public bool anamorphicFlaresUltra;

		[Range(0f, 5f)]
		public float anamorphicFlaresThreshold;

		public float anamorphicFlaresSpread;

		public bool anamorphicFlaresVertical;

		public Color anamorphicFlaresTint;

		public bool anamorphicFlaresBlur;

		public bool depthOfField;

		public bool depthOfFieldTransparencySupport;

		public Transform depthOfFieldTargetFocus;

		public bool depthOfFieldAutofocus;

		public LayerMask depthOfFieldAutofocusLayerMask;

		public float depthOfFieldAutofocusMinDistance;

		public float depthOfFieldAutofocusMaxDistance;

		public LayerMask depthOfFieldExclusionLayerMask;

		[Range(1f, 4f)]
		public float depthOfFieldExclusionLayerMaskDownsampling;

		[Range(1f, 4f)]
		public float depthOfFieldTransparencySupportDownsampling;

		[Range(0.9f, 1f)]
		public float depthOfFieldExclusionBias;

		[Range(1f, 100f)]
		public float depthOfFieldDistance;

		[Range(0.001f, 1f)]
		public float depthOfFieldFocusSpeed;

		[Range(1f, 5f)]
		public int depthOfFieldDownsampling;

		public int depthOfFieldMaxSamples;

		[Range(0.005f, 0.5f)]
		public float depthOfFieldFocalLength;

		public float depthOfFieldAperture;

		public bool depthOfFieldForegroundBlur;

		public bool depthOfFieldForegroundBlurHQ;

		public float depthOfFieldForegroundDistance;

		public bool depthOfFieldBokeh;

		[Range(0.5f, 3f)]
		public float depthOfFieldBokehThreshold;

		[Range(0f, 8f)]
		public float depthOfFieldBokehIntensity;

		public float depthOfFieldMaxBrightness;

		public FilterMode depthOfFieldFilterMode;

		public bool eyeAdaptation;

		[Range(0f, 1f)]
		public float eyeAdaptationMinExposure;

		[Range(1f, 100f)]
		public float eyeAdaptationMaxExposure;

		[Range(0f, 1f)]
		public float eyeAdaptationSpeedToLight;

		[Range(0f, 1f)]
		public float eyeAdaptationSpeedToDark;

		public bool purkinje;

		[Range(0f, 5f)]
		public float purkinjeAmount;

		[Range(0f, 1f)]
		public float purkinjeLuminanceThreshold;

		public BEAUTIFY_TMO tonemap;

		public bool sunFlares;

		[Range(0f, 1f)]
		public float sunFlaresIntensity;

		[Range(0f, 1f)]
		public float sunFlaresSolarWindSpeed;

		public Color sunFlaresTint;

		[Range(1f, 5f)]
		public int sunFlaresDownsampling;

		[Range(0f, 1f)]
		public float sunFlaresSunIntensity;

		[Range(0f, 1f)]
		public float sunFlaresSunDiskSize;

		[Range(0f, 10f)]
		public float sunFlaresSunRayDiffractionIntensity;

		[Range(0f, 1f)]
		public float sunFlaresSunRayDiffractionThreshold;

		[Range(0f, 0.2f)]
		public float sunFlaresCoronaRays1Length;

		public int sunFlaresCoronaRays1Streaks;

		[Range(0f, 0.1f)]
		public float sunFlaresCoronaRays1Spread;

		[Range(0f, (float)Math.PI * 2f)]
		public float sunFlaresCoronaRays1AngleOffset;

		[Range(0f, 0.2f)]
		public float sunFlaresCoronaRays2Length;

		public int sunFlaresCoronaRays2Streaks;

		[Range(0f, 0.1f)]
		public float sunFlaresCoronaRays2Spread;

		[Range(0f, (float)Math.PI * 2f)]
		public float sunFlaresCoronaRays2AngleOffset;

		[Range(0f, 1f)]
		public float sunFlaresGhosts1Size;

		[Range(-3f, 3f)]
		public float sunFlaresGhosts1Offset;

		[Range(0f, 1f)]
		public float sunFlaresGhosts1Brightness;

		[Range(0f, 1f)]
		public float sunFlaresGhosts2Size;

		[Range(-3f, 3f)]
		public float sunFlaresGhosts2Offset;

		[Range(0f, 1f)]
		public float sunFlaresGhosts2Brightness;

		[Range(0f, 1f)]
		public float sunFlaresGhosts3Size;

		[Range(-3f, 3f)]
		public float sunFlaresGhosts3Brightness;

		[Range(0f, 1f)]
		public float sunFlaresGhosts3Offset;

		[Range(0f, 1f)]
		public float sunFlaresGhosts4Size;

		[Range(-3f, 3f)]
		public float sunFlaresGhosts4Offset;

		[Range(0f, 1f)]
		public float sunFlaresGhosts4Brightness;

		[Range(0f, 1f)]
		public float sunFlaresHaloOffset;

		[Range(0f, 50f)]
		public float sunFlaresHaloAmplitude;

		[Range(0f, 1f)]
		public float sunFlaresHaloIntensity;

		public bool sunFlaresRotationDeadZone;

		public bool blur;

		[Range(0f, 4f)]
		public float blurIntensity;

		public int pixelateAmount;

		public bool pixelateDownscale;

		public void Load(Beautify b)
		{
		}

		public void Save(Beautify b)
		{
		}
	}
}
