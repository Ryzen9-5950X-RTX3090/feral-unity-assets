using UnityEngine;
using UnityEngine.Rendering;

[AddComponentMenu("")]
public class AmplifyOcclusionBase : MonoBehaviour
{
	public enum ApplicationMethod
	{
		PostEffect,
		Deferred,
		Debug
	}

	public enum PerPixelNormalSource
	{
		None,
		Camera,
		GBuffer,
		GBufferOctaEncoded
	}

	public enum SampleCountLevel
	{
		Low,
		Medium,
		High,
		VeryHigh
	}

	private struct CmdBuffer
	{
		public CommandBuffer cmdBuffer;

		public CameraEvent cmdBufferEvent;

		public string cmdBufferName;
	}

	private struct TargetDesc
	{
		public int fullWidth;

		public int fullHeight;

		public int width;

		public int height;

		public float oneOverWidth;

		public float oneOverHeight;
	}

	private static class ShaderPass
	{
		public const int CombineDownsampledOcclusionDepth = 16;

		public const int BlurHorizontal1 = 0;

		public const int BlurVertical1 = 1;

		public const int BlurHorizontal2 = 2;

		public const int BlurVertical2 = 3;

		public const int BlurHorizontal3 = 4;

		public const int BlurVertical3 = 5;

		public const int BlurHorizontal4 = 6;

		public const int BlurVertical4 = 7;

		public const int ApplyDebug = 0;

		public const int ApplyDebugTemporal = 1;

		public const int ApplyDeferred = 5;

		public const int ApplyDeferredTemporal = 6;

		public const int ApplyDeferredLog = 10;

		public const int ApplyDeferredLogTemporal = 11;

		public const int ApplyPostEffect = 15;

		public const int ApplyPostEffectTemporal = 16;

		public const int ApplyPostEffectTemporalMultiply = 20;

		public const int ApplyDeferredTemporalMultiply = 21;

		public const int OcclusionLow_None = 0;

		public const int OcclusionLow_Camera = 1;

		public const int OcclusionLow_GBuffer = 2;

		public const int OcclusionLow_GBufferOctaEncoded = 3;
	}

	private static class PropertyID
	{
		public static readonly int _AO_Radius;

		public static readonly int _AO_PowExponent;

		public static readonly int _AO_Bias;

		public static readonly int _AO_Levels;

		public static readonly int _AO_ThicknessDecay;

		public static readonly int _AO_BlurSharpness;

		public static readonly int _AO_CameraViewLeft;

		public static readonly int _AO_CameraViewRight;

		public static readonly int _AO_ProjMatrixLeft;

		public static readonly int _AO_ProjMatrixRight;

		public static readonly int _AO_InvViewProjMatrixLeft;

		public static readonly int _AO_PrevViewProjMatrixLeft;

		public static readonly int _AO_PrevInvViewProjMatrixLeft;

		public static readonly int _AO_InvViewProjMatrixRight;

		public static readonly int _AO_PrevViewProjMatrixRight;

		public static readonly int _AO_PrevInvViewProjMatrixRight;

		public static readonly int _AO_GBufferNormals;

		public static readonly int _AO_Target_TexelSize;

		public static readonly int _AO_TemporalCurveAdj;

		public static readonly int _AO_TemporalMotionSensibility;

		public static readonly int _AO_CurrOcclusionDepth;

		public static readonly int _AO_TemporalAccumm;

		public static readonly int _AO_TemporalDirections;

		public static readonly int _AO_TemporalOffsets;

		public static readonly int _AO_OcclusionTexture;

		public static readonly int _AO_GBufferAlbedo;

		public static readonly int _AO_GBufferEmission;

		public static readonly int _AO_UVToView;

		public static readonly int _AO_HalfProjScale;

		public static readonly int _AO_FadeParams;

		public static readonly int _AO_FadeValues;

		public static readonly int _AO_FadeToTint;

		public static readonly int _AO_Source_TexelSize;

		public static readonly int _AO_Source;
	}

	[Header("Ambient Occlusion")]
	[Tooltip("How to inject the occlusion: Post Effect = Overlay, Deferred = Deferred Injection, Debug - Vizualize.")]
	public ApplicationMethod ApplyMethod;

	[Tooltip("Number of samples per pass.")]
	public SampleCountLevel SampleCount;

	[Tooltip("Source of per-pixel normals: None = All, Camera = Forward, GBuffer = Deferred.")]
	public PerPixelNormalSource PerPixelNormals;

	[Tooltip("Final applied intensity of the occlusion effect.")]
	[Range(0f, 1f)]
	public float Intensity;

	[Tooltip("Color tint for occlusion.")]
	public Color Tint;

	[Tooltip("Radius spread of the occlusion.")]
	[Range(0f, 32f)]
	public float Radius;

	[Tooltip("Power exponent attenuation of the occlusion.")]
	[Range(0f, 16f)]
	public float PowerExponent;

	[Tooltip("Controls the initial occlusion contribution offset.")]
	[Range(0f, 0.99f)]
	public float Bias;

	[Tooltip("Controls the thickness occlusion contribution.")]
	[Range(0f, 1f)]
	public float Thickness;

	[Tooltip("Compute the Occlusion and Blur at half of the resolution.")]
	public bool Downsample;

	[Header("Distance Fade")]
	[Tooltip("Control parameters at faraway.")]
	public bool FadeEnabled;

	[Tooltip("Distance in Unity unities that start to fade.")]
	public float FadeStart;

	[Tooltip("Length distance to performe the transition.")]
	public float FadeLength;

	[Tooltip("Final Intensity parameter.")]
	[Range(0f, 1f)]
	public float FadeToIntensity;

	public Color FadeToTint;

	[Tooltip("Final Radius parameter.")]
	[Range(0f, 32f)]
	public float FadeToRadius;

	[Tooltip("Final PowerExponent parameter.")]
	[Range(0f, 16f)]
	public float FadeToPowerExponent;

	[Tooltip("Final Thickness parameter.")]
	[Range(0f, 1f)]
	public float FadeToThickness;

	[Header("Bilateral Blur")]
	public bool BlurEnabled;

	[Tooltip("Radius in screen pixels.")]
	[Range(1f, 4f)]
	public int BlurRadius;

	[Tooltip("Number of times that the Blur will repeat.")]
	[Range(1f, 4f)]
	public int BlurPasses;

	[Tooltip("Sharpness of blur edge-detection: 0 = Softer Edges, 20 = Sharper Edges.")]
	[Range(0f, 20f)]
	public float BlurSharpness;

	[Header("Temporal Filter")]
	[Tooltip("Accumulates the effect over the time.")]
	public bool FilterEnabled;

	[Tooltip("Controls the accumulation decayment: 0 = More flicker with less ghosting, 1 = Less flicker with more ghosting.")]
	[Range(0f, 1f)]
	public float FilterBlending;

	[Tooltip("Controls the discard sensitivity based on the motion of the scene and objects.")]
	[Range(0f, 1f)]
	public float FilterResponse;

	[Tooltip("Reduces ghosting effect near the objects's edges while moving.")]
	private bool TemporalDilation;

	private bool m_HDR;

	private bool m_MSAA;

	private PerPixelNormalSource m_prevPerPixelNormals;

	private ApplicationMethod m_prevApplyMethod;

	private bool m_prevDeferredReflections;

	private SampleCountLevel m_prevSampleCount;

	private bool m_prevDownsample;

	private bool m_prevBlurEnabled;

	private int m_prevBlurRadius;

	private int m_prevBlurPasses;

	private bool m_prevFilterEnabled;

	private bool m_prevHDR;

	private bool m_prevMSAA;

	private Camera m_targetCamera;

	private RenderTargetIdentifier[] applyDebugTargetsTemporal;

	private RenderTargetIdentifier[] applyDeferredTargets_Log_Temporal;

	private RenderTargetIdentifier[] applyDeferredTargetsTemporal;

	private RenderTargetIdentifier[] applyOcclusionTemporal;

	private RenderTargetIdentifier[] applyPostEffectTargetsTemporal;

	private bool useMRTBlendingFallback;

	private CmdBuffer m_commandBuffer_Occlusion;

	private CmdBuffer m_commandBuffer_Apply;

	private static Mesh m_quadMesh;

	private static Material m_occlusionMat;

	private static Material m_blurMat;

	private static Material m_applyOcclusionMat;

	private RenderTextureFormat m_occlusionRTFormat;

	private RenderTextureFormat m_accumTemporalRTFormat;

	private RenderTextureFormat m_temporaryEmissionRTFormat;

	private bool m_paramsChanged;

	private RenderTexture m_occlusionDepthRT;

	private RenderTexture[] m_temporalAccumRT;

	private uint m_sampleStep;

	private uint m_curStepIdx;

	private static readonly int PerPixelNormalSourceCount;

	private Matrix4x4 m_prevViewProjMatrixLeft;

	private Matrix4x4 m_prevInvViewProjMatrixLeft;

	private Matrix4x4 m_prevViewProjMatrixRight;

	private Matrix4x4 m_prevInvViewProjMatrixRight;

	private static readonly float[] m_temporalRotations;

	private static readonly float[] m_spatialOffsets;

	private readonly RenderTargetIdentifier[] m_applyDeferredTargets;

	private readonly RenderTargetIdentifier[] m_applyDeferredTargets_Log;

	private TargetDesc m_target;

	private bool UsingTemporalFilter
	{
		get
		{
			return default(bool);
		}
	}

	private bool UsingMotionVectors
	{
		get
		{
			return default(bool);
		}
	}

	private void createCommandBuffer(ref CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent)
	{
	}

	private void cleanupCommandBuffer(ref CmdBuffer aCmdBuffer)
	{
	}

	private void createQuadMesh()
	{
	}

	private void PerformBlit(CommandBuffer cb, Material mat, int pass)
	{
	}

	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg)
	{
		return null;
	}

	private void checkMaterials(bool aThroughErrorMsg)
	{
	}

	private bool checkRenderTextureFormats()
	{
		return default(bool);
	}

	private void OnEnable()
	{
	}

	private void Reset()
	{
	}

	private void OnDisable()
	{
	}

	private void releaseRT()
	{
	}

	private void ClearHistory()
	{
	}

	private bool checkParamsChanged()
	{
		return default(bool);
	}

	private void updateParams()
	{
	}

	private void Update()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Point)
	{
		return default(int);
	}

	private void safeReleaseTemporaryRT(CommandBuffer cb, int id)
	{
	}

	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = FilterMode.Point, int antiAliasing = 1)
	{
		return null;
	}

	private void safeReleaseRT(ref RenderTexture rt)
	{
	}

	private void BeginSample(CommandBuffer cb, string name)
	{
	}

	private void EndSample(CommandBuffer cb, string name)
	{
	}

	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb)
	{
	}

	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight)
	{
	}

	private int getTemporalPass()
	{
		return default(int);
	}

	private void commandBuffer_TemporalFilter(CommandBuffer cb)
	{
	}

	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget)
	{
	}

	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb)
	{
	}

	private void commandBuffer_FillApplyDebug(CommandBuffer cb)
	{
	}

	private bool isStereoSinglePassEnabled()
	{
		return default(bool);
	}

	private void UpdateGlobalShaderConstants()
	{
	}

	private void UpdateGlobalShaderConstants_AmbientOcclusion()
	{
	}

	private void UpdateGlobalShaderConstants_Matrices()
	{
	}
}
