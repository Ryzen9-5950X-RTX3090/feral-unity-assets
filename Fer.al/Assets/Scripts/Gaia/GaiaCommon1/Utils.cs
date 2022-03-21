using System;
using System.IO;
using UnityEngine;

namespace GaiaCommon1
{
	public class Utils : MonoBehaviour
	{
		public static string FixFileName(string sourceFileName)
		{
			return null;
		}

		public static FileStream OpenRead(string path)
		{
			return null;
		}

		public static string ReadAllText(string path)
		{
			return null;
		}

		public static void WriteAllText(string path, string contents)
		{
		}

		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		public static string GetEditorScriptsPath(AppConfig appConfig)
		{
			return null;
		}

		public static string GetAppsSubfolder(string appFolder, string subfolderPath)
		{
			return null;
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

		public static int GetFrapoch()
		{
			return default(int);
		}

		public static int TimeToFrapoch(DateTime time)
		{
			return default(int);
		}

		public static DateTime FrapochToLocalDate(int seconds)
		{
			return default(DateTime);
		}

		public static DateTime FrapochToLocalDate(double seconds)
		{
			return default(DateTime);
		}

		public static bool IsInLayerMask(GameObject obj, LayerMask mask)
		{
			return default(bool);
		}

		public static bool IsSameTexture(Texture2D tex1, Texture2D tex2, bool checkID = false)
		{
			return default(bool);
		}

		public static bool IsSameGameObject(GameObject go1, GameObject go2, bool checkID = false)
		{
			return default(bool);
		}

		public static Type GetType(string TypeName)
		{
			return null;
		}
	}
}
