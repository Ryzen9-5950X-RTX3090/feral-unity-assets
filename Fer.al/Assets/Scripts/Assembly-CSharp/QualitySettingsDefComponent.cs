using System;
using UnityEngine;

[Serializable]
[ChartComponent("QualitySettings")]
public class QualitySettingsDefComponent : DefComponent
{
	[ChartInt]
	public int resolutionDivider;

	[ChartInt]
	public int pixelLightCount;

	[ChartInt]
	public int masterTextureLimit;

	[ChartEnum]
	public AnisotropicFiltering anisotropicFiltering;

	[ChartInt]
	public int antiAliasing;

	[ChartBool]
	public bool softParticles;

	[ChartBool]
	public bool realtimeReflectionProbes;

	[ChartBool]
	public bool billboardsFaceCameraPosition;

	[ChartFloat]
	public float resolutionScalingFixedDPIFactor;

	[ChartBool]
	public bool streamingMipmapsActive;

	[ChartEnum]
	public ShadowmaskMode shadowmaskMode;

	[ChartEnum]
	public ShadowQuality shadows;

	[ChartEnum]
	public ShadowResolution shadowResolution;

	[ChartEnum]
	public ShadowProjection shadowProjection;

	[ChartFloat]
	public float shadowDistance;

	[ChartFloat]
	public float shadowNearPlaneOffset;

	[ChartInt]
	public int shadowCascades;

	[ChartEnum]
	public SkinWeights skinWeights;

	[ChartInt]
	public int vSyncCount;

	[ChartFloat]
	public float lodBias;

	[ChartInt]
	public int maximumLODLevel;

	[ChartInt]
	public int particleRaycastBudget;

	[ChartInt]
	public int asyncUploadTimeSlice;

	[ChartInt]
	public int asyncUploadBufferSize;

	[ChartBool]
	public bool asyncUploadPersistentBuffer;

	[ChartInt]
	public int targetFrameRate;

	[ChartInt]
	public int qualityLevel;
}
