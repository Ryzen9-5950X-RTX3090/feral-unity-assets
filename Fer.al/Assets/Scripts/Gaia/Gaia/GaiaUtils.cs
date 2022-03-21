using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	public class GaiaUtils : MonoBehaviour
	{
		public static string GetGaiaAssetDirectory()
		{
			return null;
		}

		public static string GetGaiaAssetDirectory(GaiaConstants.FeatureType featureType)
		{
			return null;
		}

		public static List<string> GetGaiaStampsList(GaiaConstants.FeatureType featureType)
		{
			return null;
		}

		public static string GetGaiaAssetPath(GaiaConstants.FeatureType featureType, string assetName)
		{
			return null;
		}

		public static string GetGaiaStampAssetPath(GaiaConstants.FeatureType featureType, string assetName)
		{
			return null;
		}

		public static string GetGaiaStampPath(Texture2D source)
		{
			return null;
		}

		public static bool CheckValidGaiaStampPath(Texture2D source)
		{
			return default(bool);
		}

		public static void CreateGaiaAssetDirectories()
		{
		}

		public static T[] GetAtPath<T>(string path)
		{
			return null;
		}

		public static void CreateAsset<T>() where T : ScriptableObject
		{
		}

		public static string GetAssetPath(UnityEngine.Object uo)
		{
			return null;
		}

		public static string WrapScriptableObject(ScriptableObject so)
		{
			return null;
		}

		public static void UnwrapScriptableObject(string path, string newpath)
		{
		}

		public static string WrapGameObjectAsPrefab(GameObject go)
		{
			return null;
		}

		public static string GetAssetPath(string fileName)
		{
			return null;
		}

		public static string GetAssetPath(string name, string type)
		{
			return null;
		}

		public static UnityEngine.Object GetAsset(string fileNameOrPath, Type assetType)
		{
			return null;
		}

		public static GameObject GetAssetPrefab(string name)
		{
			return null;
		}

		public static ScriptableObject GetAssetScriptableObject(string name)
		{
			return null;
		}

		public static Texture2D GetAssetTexture2D(string name)
		{
			return null;
		}

		public static void MakeTextureNormal(Texture2D texture)
		{
		}

		public static void MakeTextureReadable(Texture2D texture)
		{
		}

		public static void MakeTextureUncompressed(Texture2D texture)
		{
		}

		public static void CompressToSingleChannelFileImage(float[,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32, bool exportPNG = true, bool exportJPG = true)
		{
		}

		public static void CompressToMultiChannelFileImage(float[,,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32, bool exportPNG = true, bool exportJPG = true)
		{
		}

		public static void CompressToMultiChannelFileImage(string imageName, HeightMap r, HeightMap g, HeightMap b, HeightMap a, TextureFormat imageStorageFormat, GaiaConstants.ImageFileType imageFileType)
		{
		}

		public static float[,] ConvertTextureToArray(Texture2D texture)
		{
			return null;
		}

		public static float[,] DecompressFromSingleChannelFileImage(string fileName, int width, int height, TextureFormat imageStorageFormat = TextureFormat.RGBA32, bool channelR = true, bool channelG = false, bool channelB = false, bool channelA = false)
		{
			return null;
		}

		public static float[,] DecompressFromSingleChannelTexture(Texture2D importTexture, bool channelR = true, bool channelG = false, bool channelB = false, bool channelA = false)
		{
			return null;
		}

		public static void ExportJPG(string fileName, Texture2D texture)
		{
		}

		public static void ExportPNG(string fileName, Texture2D texture)
		{
		}

		public static float[,] LoadRawFile(string fileName)
		{
			return null;
		}

		public static Mesh CreateMesh(float[,] heightmap, Vector3 targetSize)
		{
			return null;
		}

		public static Bounds GetBounds(GameObject go)
		{
			return default(Bounds);
		}

		private Vector3 Rotate90LeftXAxis(Vector3 input)
		{
			return default(Vector3);
		}

		private Vector3 Rotate90RightXAxis(Vector3 input)
		{
			return default(Vector3);
		}

		private Vector3 Rotate90LeftYAxis(Vector3 input)
		{
			return default(Vector3);
		}

		private Vector3 Rotate90RightYAxis(Vector3 input)
		{
			return default(Vector3);
		}

		private Vector3 Rotate90LeftZAxis(Vector3 input)
		{
			return default(Vector3);
		}

		private Vector3 Rotate90RightZAxis(Vector3 input)
		{
			return default(Vector3);
		}

		public static bool Math_ApproximatelyEqual(float a, float b, float threshold)
		{
			return default(bool);
		}

		public static bool Math_ApproximatelyEqual(float a, float b)
		{
			return default(bool);
		}

		public static bool Math_IsPowerOf2(int value)
		{
			return default(bool);
		}

		public static float Math_Clamp(float min, float max, float value)
		{
			return default(float);
		}

		public static float Math_Modulo(float value, float mod)
		{
			return default(float);
		}

		public static int Math_Modulo(int value, int mod)
		{
			return default(int);
		}

		public static float Math_InterpolateLinear(float value1, float value2, float fraction)
		{
			return default(float);
		}

		public static float Math_InterpolateSmooth(float value1, float value2, float fraction)
		{
			return default(float);
		}

		public static float Math_Distance(float x1, float y1, float x2, float y2)
		{
			return default(float);
		}

		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction)
		{
			return default(float);
		}

		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction)
		{
			return default(float);
		}

		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle)
		{
			return default(Vector3);
		}

		public static GaiaSettings GetGaiaSettings()
		{
			return null;
		}
	}
}
