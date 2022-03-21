using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BeautifyEffect
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Beautify")]
	[HelpURL("http://kronnect.com/taptapgo")]
	public class Beautify : MonoBehaviour
	{
		[SerializeField]
		private BEAUTIFY_PRESET _preset;

		[SerializeField]
		private BEAUTIFY_QUALITY _quality;

		[SerializeField]
		private BeautifyProfile _profile;

		[SerializeField]
		private bool _compareMode;

		[SerializeField]
		[Range(-(float)Math.PI, (float)Math.PI)]
		private float _compareLineAngle;

		[SerializeField]
		[Range(0.0001f, 0.05f)]
		private float _compareLineWidth;

		[SerializeField]
		[Range(0f, 0.2f)]
		private float _dither;

		[SerializeField]
		[Range(0f, 1f)]
		private float _ditherDepth;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sharpenMinDepth;

		[SerializeField]
		[Range(0f, 1.1f)]
		private float _sharpenMaxDepth;

		[SerializeField]
		[Range(0f, 15f)]
		private float _sharpen;

		[SerializeField]
		[Range(0f, 0.05f)]
		private float _sharpenDepthThreshold;

		[SerializeField]
		private Color _tintColor;

		[SerializeField]
		[Range(0f, 0.2f)]
		private float _sharpenRelaxation;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sharpenClamp;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sharpenMotionSensibility;

		[SerializeField]
		private float _saturate;

		[SerializeField]
		[Range(0.5f, 1.5f)]
		private float _contrast;

		[SerializeField]
		private float _brightness;

		[SerializeField]
		private float _daltonize;

		[SerializeField]
		private bool _vignetting;

		[SerializeField]
		private Color _vignettingColor;

		[SerializeField]
		[Range(0f, 1f)]
		private float _vignettingFade;

		[SerializeField]
		private bool _vignettingCircularShape;

		[SerializeField]
		private float _vignettingAspectRatio;

		[SerializeField]
		[Range(0f, 1f)]
		private float _vignettingBlink;

		[SerializeField]
		private Texture2D _vignettingMask;

		[SerializeField]
		private bool _frame;

		[SerializeField]
		private Color _frameColor;

		[SerializeField]
		private Texture2D _frameMask;

		[SerializeField]
		private bool _lut;

		[SerializeField]
		[Range(0f, 1f)]
		private float _lutIntensity;

		[SerializeField]
		private Texture2D _lutTexture;

		[SerializeField]
		private bool _nightVision;

		[SerializeField]
		private Color _nightVisionColor;

		[SerializeField]
		private bool _outline;

		[SerializeField]
		private Color _outlineColor;

		[SerializeField]
		private bool _thermalVision;

		[SerializeField]
		private bool _lensDirt;

		[SerializeField]
		[Range(0f, 1f)]
		private float _lensDirtThreshold;

		[SerializeField]
		[Range(0f, 1f)]
		private float _lensDirtIntensity;

		[SerializeField]
		private Texture2D _lensDirtTexture;

		[SerializeField]
		private bool _bloom;

		[SerializeField]
		private LayerMask _bloomCullingMask;

		[SerializeField]
		[Range(1f, 4f)]
		private float _bloomLayerMaskDownsampling;

		[SerializeField]
		[Range(0f, 10f)]
		private float _bloomIntensity;

		[SerializeField]
		private float _bloomMaxBrightness;

		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost0;

		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost1;

		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost2;

		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost3;

		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost4;

		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost5;

		[SerializeField]
		private bool _bloomAntiflicker;

		[SerializeField]
		private bool _bloomUltra;

		[SerializeField]
		[Range(0f, 5f)]
		private float _bloomThreshold;

		[SerializeField]
		private bool _bloomCustomize;

		[SerializeField]
		private bool _bloomDebug;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight0;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight1;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight2;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight3;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight4;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight5;

		[SerializeField]
		private bool _bloomBlur;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomDepthAtten;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _bloomLayerZBias;

		[SerializeField]
		private bool _anamorphicFlares;

		[SerializeField]
		[Range(0f, 10f)]
		private float _anamorphicFlaresIntensity;

		[SerializeField]
		private bool _anamorphicFlaresAntiflicker;

		[SerializeField]
		private bool _anamorphicFlaresUltra;

		[SerializeField]
		[Range(0f, 5f)]
		private float _anamorphicFlaresThreshold;

		[SerializeField]
		private float _anamorphicFlaresSpread;

		[SerializeField]
		private bool _anamorphicFlaresVertical;

		[SerializeField]
		private Color _anamorphicFlaresTint;

		[SerializeField]
		private bool _anamorphicFlaresBlur;

		[SerializeField]
		private bool _depthOfField;

		[SerializeField]
		private bool _depthOfFieldTransparencySupport;

		[SerializeField]
		private Transform _depthOfFieldTargetFocus;

		[SerializeField]
		private bool _depthOfFieldDebug;

		[SerializeField]
		private bool _depthOfFieldAutofocus;

		[SerializeField]
		private float _depthOfFieldAutofocusMinDistance;

		[SerializeField]
		private float _depthOfFieldAutofocusMaxDistance;

		[SerializeField]
		private LayerMask _depthOfFieldAutofocusLayerMask;

		[SerializeField]
		private LayerMask _depthOfFieldExclusionLayerMask;

		[SerializeField]
		[Range(1f, 4f)]
		private float _depthOfFieldExclusionLayerMaskDownsampling;

		[SerializeField]
		[Range(1f, 4f)]
		private float _depthOfFieldTransparencySupportDownsampling;

		[SerializeField]
		[Range(0.9f, 1f)]
		private float _depthOfFieldExclusionBias;

		[SerializeField]
		[Range(1f, 100f)]
		private float _depthOfFieldDistance;

		[SerializeField]
		[Range(0.001f, 5f)]
		private float _depthOfFieldFocusSpeed;

		[SerializeField]
		[Range(1f, 5f)]
		private int _depthOfFieldDownsampling;

		[SerializeField]
		[Range(0f, 16f)]
		private int _depthOfFieldMaxSamples;

		[SerializeField]
		[Range(0.005f, 0.5f)]
		private float _depthOfFieldFocalLength;

		[SerializeField]
		private float _depthOfFieldAperture;

		[SerializeField]
		private bool _depthOfFieldForegroundBlur;

		[SerializeField]
		private bool _depthOfFieldForegroundBlurHQ;

		[SerializeField]
		private float _depthOfFieldForegroundDistance;

		[SerializeField]
		private bool _depthOfFieldBokeh;

		[SerializeField]
		[Range(0.5f, 3f)]
		private float _depthOfFieldBokehThreshold;

		[SerializeField]
		[Range(0f, 8f)]
		private float _depthOfFieldBokehIntensity;

		[SerializeField]
		private float _depthOfFieldMaxBrightness;

		[SerializeField]
		private FilterMode _depthOfFieldFilterMode;

		[SerializeField]
		private bool _eyeAdaptation;

		[SerializeField]
		[Range(0f, 1f)]
		private float _eyeAdaptationMinExposure;

		[SerializeField]
		[Range(1f, 100f)]
		private float _eyeAdaptationMaxExposure;

		[SerializeField]
		[Range(0f, 1f)]
		private float _eyeAdaptationSpeedToLight;

		[SerializeField]
		[Range(0f, 1f)]
		private float _eyeAdaptationSpeedToDark;

		[SerializeField]
		private bool _purkinje;

		[SerializeField]
		[Range(0f, 5f)]
		private float _purkinjeAmount;

		[SerializeField]
		[Range(0f, 1f)]
		private float _purkinjeLuminanceThreshold;

		[SerializeField]
		private BEAUTIFY_TMO _tonemap;

		[SerializeField]
		private bool _sunFlares;

		[SerializeField]
		private Transform _sun;

		[SerializeField]
		private LayerMask _sunFlaresLayerMask;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresIntensity;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSolarWindSpeed;

		[SerializeField]
		private Color _sunFlaresTint;

		[SerializeField]
		[Range(1f, 5f)]
		private int _sunFlaresDownsampling;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSunIntensity;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSunDiskSize;

		[SerializeField]
		[Range(0f, 10f)]
		private float _sunFlaresSunRayDiffractionIntensity;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSunRayDiffractionThreshold;

		[SerializeField]
		[Range(0f, 0.2f)]
		private float _sunFlaresCoronaRays1Length;

		[SerializeField]
		[Range(0f, 30f)]
		private int _sunFlaresCoronaRays1Streaks;

		[SerializeField]
		[Range(0f, 0.1f)]
		private float _sunFlaresCoronaRays1Spread;

		[SerializeField]
		[Range(0f, (float)Math.PI * 2f)]
		private float _sunFlaresCoronaRays1AngleOffset;

		[SerializeField]
		[Range(0f, 0.2f)]
		private float _sunFlaresCoronaRays2Length;

		[SerializeField]
		[Range(0f, 30f)]
		private int _sunFlaresCoronaRays2Streaks;

		[SerializeField]
		[Range(0f, 0.1f)]
		private float _sunFlaresCoronaRays2Spread;

		[SerializeField]
		[Range(0f, (float)Math.PI * 2f)]
		private float _sunFlaresCoronaRays2AngleOffset;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts1Size;

		[SerializeField]
		[Range(-3f, 3f)]
		private float _sunFlaresGhosts1Offset;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts1Brightness;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts2Size;

		[SerializeField]
		[Range(-3f, 3f)]
		private float _sunFlaresGhosts2Offset;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts2Brightness;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts3Size;

		[SerializeField]
		[Range(-3f, 3f)]
		private float _sunFlaresGhosts3Brightness;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts3Offset;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts4Size;

		[SerializeField]
		[Range(-3f, 3f)]
		private float _sunFlaresGhosts4Offset;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts4Brightness;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresHaloOffset;

		[SerializeField]
		[Range(0f, 50f)]
		private float _sunFlaresHaloAmplitude;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresHaloIntensity;

		[SerializeField]
		private bool _sunFlaresRotationDeadZone;

		[SerializeField]
		private bool _blur;

		[SerializeField]
		[Range(0f, 4f)]
		private float _blurIntensity;

		[SerializeField]
		[Range(1f, 256f)]
		private int _pixelateAmount;

		[SerializeField]
		private bool _pixelateDownscale;

		[SerializeField]
		[Range(0f, 20f)]
		private float _antialiasStrength;

		[SerializeField]
		[Range(0f, 0.05f)]
		private float _antialiasDepthThreshold;

		public bool isDirty;

		private static Beautify _beautify;

		public const string SKW_BLOOM = "BEAUTIFY_BLOOM";

		public const string SKW_LUT = "BEAUTIFY_LUT";

		public const string SKW_NIGHT_VISION = "BEAUTIFY_NIGHT_VISION";

		public const string SKW_THERMAL_VISION = "BEAUTIFY_THERMAL_VISION";

		public const string SKW_OUTLINE = "BEAUTIFY_OUTLINE";

		public const string SKW_FRAME = "BEAUTIFY_FRAME";

		public const string SKW_FRAME_MASK = "BEAUTIFY_FRAME_MASK";

		public const string SKW_DALTONIZE = "BEAUTIFY_DALTONIZE";

		public const string SKW_DIRT = "BEAUTIFY_DIRT";

		public const string SKW_VIGNETTING = "BEAUTIFY_VIGNETTING";

		public const string SKW_VIGNETTING_MASK = "BEAUTIFY_VIGNETTING_MASK";

		public const string SKW_DEPTH_OF_FIELD = "BEAUTIFY_DEPTH_OF_FIELD";

		public const string SKW_DEPTH_OF_FIELD_TRANSPARENT = "BEAUTIFY_DEPTH_OF_FIELD_TRANSPARENT";

		public const string SKW_EYE_ADAPTATION = "BEAUTIFY_EYE_ADAPTATION";

		public const string SKW_TONEMAP_ACES = "BEAUTIFY_TONEMAP_ACES";

		public const string SKW_PURKINJE = "BEAUTIFY_PURKINJE";

		public const string SKW_BLOOM_USE_DEPTH = "BEAUTIFY_BLOOM_USE_DEPTH";

		public const string SKW_BLOOM_USE_LAYER = "BEAUTIFY_BLOOM_USE_LAYER";

		private Material bMatDesktop;

		private Material bMatMobile;

		private Material bMatBasic;

		[SerializeField]
		private Material bMat;

		private Camera currentCamera;

		private Vector3 camPrevForward;

		private Vector3 camPrevPos;

		private float currSens;

		private int renderPass;

		private RenderTextureFormat rtFormat;

		private RenderTexture[] rt;

		private RenderTexture[] rtAF;

		private RenderTexture[] rtEA;

		private RenderTexture rtEAacum;

		private RenderTexture rtEAHist;

		private float dofPrevDistance;

		private float dofLastAutofocusDistance;

		private Vector4 dofLastBokehData;

		private Camera sceneCamera;

		private Camera depthCam;

		private GameObject depthCamObj;

		private List<string> shaderKeywords;

		private Shader depthShader;

		private Shader dofExclusionShader;

		private bool shouldUpdateMaterialProperties;

		private const string BEAUTIFY_BUILD_HINT = "BeautifyBuildHint70b3";

		private float sunFlareCurrentIntensity;

		private Vector4 sunLastScrPos;

		private float sunLastRot;

		private Texture2D flareNoise;

		private RenderTexture dofDepthTexture;

		private RenderTexture dofExclusionTexture;

		private RenderTexture bloomSourceTexture;

		private RenderTexture bloomSourceDepthTexture;

		private RenderTexture pixelateTexture;

		private RenderTextureDescriptor rtDescBase;

		private float sunFlareTime;

		private int dofCurrentLayerMaskValue;

		public BEAUTIFY_PRESET preset
		{
			get
			{
				return default(BEAUTIFY_PRESET);
			}
			set
			{
			}
		}

		public BEAUTIFY_QUALITY quality
		{
			get
			{
				return default(BEAUTIFY_QUALITY);
			}
			set
			{
			}
		}

		public BeautifyProfile profile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool compareMode
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float compareLineAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float compareLineWidth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float dither
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ditherDepth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sharpenMinDepth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sharpenMaxDepth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sharpen
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sharpenDepthThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color tintColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float sharpenRelaxation
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sharpenClamp
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sharpenMotionSensibility
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float saturate
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float contrast
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float brightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float daltonize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool vignetting
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color vignettingColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float vignettingFade
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool vignettingCircularShape
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float vignettingAspectRatio
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float vignettingBlink
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Texture2D vignettingMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool frame
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color frameColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Texture2D frameMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool lut
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float lutIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Texture2D lutTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool nightVision
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color nightVisionColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool outline
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color outlineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool thermalVision
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool lensDirt
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float lensDirtThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float lensDirtIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Texture2D lensDirtTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool bloom
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public LayerMask bloomCullingMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public float bloomLayerMaskDownsampling
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomMaxBrightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomBoost0
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomBoost1
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomBoost2
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomBoost3
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomBoost4
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomBoost5
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool bloomAntiflicker
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool bloomUltra
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float bloomThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool bloomCustomize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool bloomDebug
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float bloomWeight0
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomWeight1
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomWeight2
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomWeight3
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomWeight4
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomWeight5
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool bloomBlur
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float bloomDepthAtten
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float bloomLayerZBias
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool anamorphicFlares
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float anamorphicFlaresIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool anamorphicFlaresAntiflicker
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool anamorphicFlaresUltra
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float anamorphicFlaresThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float anamorphicFlaresSpread
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool anamorphicFlaresVertical
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color anamorphicFlaresTint
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool anamorphicFlaresBlur
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool depthOfField
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool depthOfFieldTransparencySupport
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Transform depthOfFieldTargetFocus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool depthOfFieldDebug
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool depthOfFieldAutofocus
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float depthOfFieldAutofocusMinDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldAutofocusMaxDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public LayerMask depthOfFieldAutofocusLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public LayerMask depthOfFieldExclusionLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public float depthOfFieldExclusionLayerMaskDownsampling
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldTransparencySupportDownsampling
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldExclusionBias
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldFocusSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int depthOfFieldDownsampling
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int depthOfFieldMaxSamples
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float depthOfFieldFocalLength
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldAperture
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool depthOfFieldForegroundBlur
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool depthOfFieldForegroundBlurHQ
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float depthOfFieldForegroundDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool depthOfFieldBokeh
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float depthOfFieldBokehThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldBokehIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float depthOfFieldMaxBrightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public FilterMode depthOfFieldFilterMode
		{
			get
			{
				return default(FilterMode);
			}
			set
			{
			}
		}

		public bool eyeAdaptation
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float eyeAdaptationMinExposure
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float eyeAdaptationMaxExposure
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float eyeAdaptationSpeedToLight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float eyeAdaptationSpeedToDark
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool purkinje
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float purkinjeAmount
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float purkinjeLuminanceThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public BEAUTIFY_TMO tonemap
		{
			get
			{
				return default(BEAUTIFY_TMO);
			}
			set
			{
			}
		}

		public bool sunFlares
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Transform sun
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LayerMask sunFlaresLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public float sunFlaresIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresSolarWindSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color sunFlaresTint
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int sunFlaresDownsampling
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float sunFlaresSunIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresSunDiskSize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresSunRayDiffractionIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresSunRayDiffractionThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresCoronaRays1Length
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int sunFlaresCoronaRays1Streaks
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float sunFlaresCoronaRays1Spread
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresCoronaRays1AngleOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresCoronaRays2Length
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int sunFlaresCoronaRays2Streaks
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float sunFlaresCoronaRays2Spread
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresCoronaRays2AngleOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts1Size
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts1Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts1Brightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts2Size
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts2Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts2Brightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts3Size
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts3Brightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts3Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts4Size
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts4Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresGhosts4Brightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresHaloOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresHaloAmplitude
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float sunFlaresHaloIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool sunFlaresRotationDeadZone
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool blur
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float blurIntensity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int pixelateAmount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool pixelateDownscale
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float antialiasStrength
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float antialiasDepthThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public static Beautify instance
		{
			get
			{
				return null;
			}
		}

		public Camera cameraEffect
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnPreCull()
		{
		}

		private void OnPreRender()
		{
		}

		private void CleanUpRT()
		{
		}

		private void CheckDoFTransparencySupport()
		{
		}

		private void CheckDoFExclusionMask()
		{
		}

		private void CheckBloomCullingLayer()
		{
		}

		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void OnPostRender()
		{
		}

		private void BlurThis(RenderTexture rt, float blurScale = 1f)
		{
		}

		private void BlurThisDownscaling(RenderTexture rt, RenderTexture downscaled, float blurScale = 1f)
		{
		}

		private RenderTexture BlurThisOneDirection(RenderTexture rt, bool vertical, float blurScale = 1f)
		{
			return null;
		}

		private void BlurThisDoF(RenderTexture rt, int renderPass)
		{
		}

		private void BlurThisAlpha(RenderTexture rt, float blurScale = 1f)
		{
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		public void UpdateQualitySettings()
		{
		}

		public void UpdateMaterialProperties()
		{
		}

		public void UpdateMaterialPropertiesNow()
		{
		}

		private void UpdateMaterialBloomIntensityAndThreshold()
		{
		}

		private void UpdateMaterialAnamorphicIntensityAndThreshold()
		{
		}

		private void UpdateSharpenParams(float sharpen)
		{
		}

		private void UpdateDepthOfFieldData()
		{
		}

		private void UpdateDepthOfFieldBlurData(Vector2 blurDir)
		{
		}

		private void UpdateDoFAutofocusDistance()
		{
		}

		public Texture2D GenerateSepiaLUT()
		{
			return null;
		}

		public void Blink(float duration, float maxValue = 1f)
		{
		}

		[IteratorStateMachine(typeof(<DoBlink>d__699))]
		private IEnumerator DoBlink(float duration, float maxValue)
		{
			return null;
		}
	}
}
