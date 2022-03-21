using System;
using System.Collections.Generic;
using UnityEngine;

namespace JBooth.MicroSplat
{
	[CreateAssetMenu]
	[ExecuteInEditMode]
	public class TextureArrayConfig : ScriptableObject
	{
		public enum AllTextureChannel
		{
			R,
			G,
			B,
			A,
			Custom
		}

		public enum TextureChannel
		{
			R,
			G,
			B,
			A
		}

		public enum Compression
		{
			AutomaticCompressed,
			ForceDXT,
			ForcePVR,
			ForceETC2,
			ForceASTC,
			ForceCrunch,
			Uncompressed
		}

		public enum TextureSize
		{
			k4096 = 0x1000,
			k2048 = 0x800,
			k1024 = 0x400,
			k512 = 0x200,
			k256 = 0x100,
			k128 = 0x80,
			k64 = 0x40,
			k32 = 0x20
		}

		[Serializable]
		public class TextureArraySettings
		{
			public TextureSize textureSize;

			public Compression compression;

			public FilterMode filterMode;

			[Range(0f, 16f)]
			public int Aniso;

			public TextureArraySettings(TextureSize s, Compression c, FilterMode f, int a = 1)
			{
			}
		}

		public enum PBRWorkflow
		{
			Metallic,
			Specular
		}

		public enum PackingMode
		{
			Fastest,
			Quality
		}

		public enum SourceTextureSize
		{
			Unchanged = 0,
			k32 = 0x20,
			k256 = 0x100
		}

		public enum TextureMode
		{
			Basic,
			PBR
		}

		public enum ClusterMode
		{
			None,
			TwoVariations,
			ThreeVariations
		}

		[Serializable]
		public class TextureArrayGroup
		{
			public TextureArraySettings diffuseSettings;

			public TextureArraySettings normalSettings;

			public TextureArraySettings smoothSettings;

			public TextureArraySettings antiTileSettings;

			public TextureArraySettings emissiveSettings;

			public TextureArraySettings specularSettings;

			public TextureArraySettings traxDiffuseSettings;

			public TextureArraySettings traxNormalSettings;

			public TextureArraySettings decalSplatSettings;
		}

		[Serializable]
		public class PlatformTextureOverride
		{
			public TextureArrayGroup settings;
		}

		[Serializable]
		public class TextureEntry
		{
			public Texture2D diffuse;

			public Texture2D height;

			public TextureChannel heightChannel;

			public Texture2D normal;

			public Texture2D smoothness;

			public TextureChannel smoothnessChannel;

			public bool isRoughness;

			public Texture2D ao;

			public TextureChannel aoChannel;

			public Texture2D emis;

			public Texture2D metal;

			public TextureChannel metalChannel;

			public Texture2D specular;

			public Texture2D noiseNormal;

			public Texture2D detailNoise;

			public TextureChannel detailChannel;

			public Texture2D distanceNoise;

			public TextureChannel distanceChannel;

			public Texture2D traxDiffuse;

			public Texture2D traxHeight;

			public TextureChannel traxHeightChannel;

			public Texture2D traxNormal;

			public Texture2D traxSmoothness;

			public TextureChannel traxSmoothnessChannel;

			public bool traxIsRoughness;

			public Texture2D traxAO;

			public TextureChannel traxAOChannel;

			public Texture2D splat;

			public void Reset()
			{
			}

			public bool HasTextures(PBRWorkflow wf)
			{
				return default(bool);
			}
		}

		public bool diffuseIsLinear;

		[HideInInspector]
		public bool antiTileArray;

		[HideInInspector]
		public bool emisMetalArray;

		public bool traxArray;

		[HideInInspector]
		public TextureMode textureMode;

		[HideInInspector]
		public ClusterMode clusterMode;

		[HideInInspector]
		public PackingMode packingMode;

		[HideInInspector]
		public PBRWorkflow pbrWorkflow;

		[HideInInspector]
		public int hash;

		[HideInInspector]
		public Texture2DArray splatArray;

		[HideInInspector]
		public Texture2DArray diffuseArray;

		[HideInInspector]
		public Texture2DArray normalSAOArray;

		[HideInInspector]
		public Texture2DArray smoothAOArray;

		[HideInInspector]
		public Texture2DArray specularArray;

		[HideInInspector]
		public Texture2DArray diffuseArray2;

		[HideInInspector]
		public Texture2DArray normalSAOArray2;

		[HideInInspector]
		public Texture2DArray smoothAOArray2;

		[HideInInspector]
		public Texture2DArray specularArray2;

		[HideInInspector]
		public Texture2DArray diffuseArray3;

		[HideInInspector]
		public Texture2DArray normalSAOArray3;

		[HideInInspector]
		public Texture2DArray smoothAOArray3;

		[HideInInspector]
		public Texture2DArray specularArray3;

		[HideInInspector]
		public Texture2DArray emisArray;

		[HideInInspector]
		public Texture2DArray emisArray2;

		[HideInInspector]
		public Texture2DArray emisArray3;

		public TextureArrayGroup defaultTextureSettings;

		public List<PlatformTextureOverride> platformOverrides;

		public SourceTextureSize sourceTextureSize;

		[HideInInspector]
		public AllTextureChannel allTextureChannelHeight;

		[HideInInspector]
		public AllTextureChannel allTextureChannelSmoothness;

		[HideInInspector]
		public AllTextureChannel allTextureChannelAO;

		[HideInInspector]
		public List<TextureEntry> sourceTextures;

		[HideInInspector]
		public List<TextureEntry> sourceTextures2;

		[HideInInspector]
		public List<TextureEntry> sourceTextures3;

		public bool IsScatter()
		{
			return default(bool);
		}

		public bool IsDecal()
		{
			return default(bool);
		}

		public bool IsDecalSplat()
		{
			return default(bool);
		}
	}
}
