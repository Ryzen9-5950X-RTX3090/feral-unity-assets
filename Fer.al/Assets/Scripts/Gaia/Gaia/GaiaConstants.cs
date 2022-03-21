using UnityEngine;

namespace Gaia
{
	public static class GaiaConstants
	{
		public enum RawByteOrder
		{
			IBM,
			Macintosh
		}

		public enum RawBitDepth
		{
			Sixteen,
			Eight
		}

		public enum EnvironmentTarget
		{
			UltraLight,
			MobileAndVR,
			Desktop,
			PowerfulDesktop,
			Custom
		}

		public enum EnvironmentRenderer
		{
			BuiltIn,
			LightWeight2018x,
			HighDefinition2018x
		}

		public enum EnvironmentSize
		{
			FromDefaults,
			Is256MetersSq,
			Is512MetersSq,
			Is1024MetersSq,
			Is2048MetersSq,
			Is4096MetersSq,
			Is8192MetersSq,
			Is16384MetersSq
		}

		public enum EnvironmentControllerType
		{
			FirstPerson,
			FlyingCamera,
			ThirdPerson
		}

		public enum ManagerEditorMode
		{
			Standard,
			Advanced,
			Extensions,
			ShowMore
		}

		public enum ManagerEditorNewsMode
		{
			MoreOnGaia,
			MoreOnProceduralWorlds
		}

		public enum OperationMode
		{
			DesignTime,
			RuntimeInterval,
			RuntimeTriggeredInterval
		}

		public enum TerrainOperationType
		{
			AddToTerrain,
			ApplyMaskToSplatmap,
			ContrastFilter,
			GrowFeaturesFilter,
			DeNoiseFilter,
			HydraulicFilter,
			MultiplyTerrain,
			PowerOfFilter,
			QuantizeFilter,
			QuantizeCurvesFilter,
			SetTerrainToHeight,
			ShrinkFeaturesFilter,
			SubtractFromTerrain,
			ThermalFilter,
			ExportAspectMap,
			ExportBaseMap,
			ExportCurvatureMap,
			ExportFlowMap,
			ExportHeightMap,
			ExportNoiseMap,
			ExportNormalMap,
			ExportMasks,
			ExportSlopeMap
		}

		public enum MaskMergeType
		{
			AssignMask2IfGreaterThan,
			AssignMask2IfLessThan,
			AddMask2,
			MultiplyByMask2,
			SubtractMask2
		}

		public enum ErosionRainType
		{
			Constant,
			ErodePeaks,
			ErodeValleys,
			ErodeSlopes
		}

		public enum CurvatureType
		{
			Average,
			Horizontal,
			Vertical
		}

		public enum AspectType
		{
			Aspect,
			Northerness,
			Easterness
		}

		public enum NoiseType
		{
			None,
			Perlin,
			Billow,
			Ridged
		}

		public enum ImageFitnessFilterMode
		{
			None,
			ImageGreyScale,
			ImageRedChannel,
			ImageGreenChannel,
			ImageBlueChannel,
			ImageAlphaChannel,
			TerrainTexture0,
			TerrainTexture1,
			TerrainTexture2,
			TerrainTexture3,
			TerrainTexture4,
			TerrainTexture5,
			TerrainTexture6,
			TerrainTexture7,
			PerlinNoise,
			BillowNoise,
			RidgedNoise
		}

		public enum FeatureType
		{
			Adhoc,
			Bases,
			Hills,
			Islands,
			Lakes,
			Mesas,
			Mountains,
			Plains,
			Rivers,
			Rocks,
			Valleys,
			Villages,
			Waterfalls
		}

		public enum GeneratorBorderStyle
		{
			None,
			Mountains,
			Water
		}

		public enum FeatureOperation
		{
			RaiseHeight,
			LowerHeight,
			BlendHeight,
			StencilHeight,
			DifferenceHeight
		}

		public enum SpawnerShape
		{
			Box,
			Sphere
		}

		public enum SpawnerLocation
		{
			RandomLocation,
			RandomLocationClustered,
			EveryLocation,
			EveryLocationJittered
		}

		public enum SpawnerLocationCheckType
		{
			PointCheck,
			BoundedAreaCheck
		}

		public enum SpawnerRuleSelector
		{
			All,
			Fittest,
			WeightedFittest,
			Random
		}

		public enum SpawnerResourceType
		{
			TerrainTexture,
			TerrainDetail,
			TerrainTree,
			GameObject
		}

		public enum ImageFileType
		{
			Jpg,
			Png,
			Exr
		}

		public enum StorageFormat
		{
			PNG,
			JPG
		}

		public enum ImageChannel
		{
			R,
			G,
			B,
			A
		}

		public static readonly string AssetDir;

		public static readonly string AssetDirFromAssetDB;

		public static float VirginTerrainCheckThreshold;

		public const TextureFormat defaultTextureFormat = TextureFormat.RGBA32;

		public const TextureFormat fmtHmTextureFormat = TextureFormat.RGBA32;

		public const TextureFormat fmtRGBA32 = TextureFormat.RGBA32;

		public const StorageFormat defaultImageStorageFormat = StorageFormat.PNG;

		public const ImageChannel defaultImageStorageChannel = ImageChannel.R;
	}
}
