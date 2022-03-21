using System.Runtime.InteropServices;
using FMOD;
using UnityEngine;

namespace FMODUnity
{
	public static class RuntimeUtils
	{
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		public static THREAD_TYPE ToFMODThreadType(ThreadType threadType)
		{
			return default(THREAD_TYPE);
		}

		public static string DisplayName(this ThreadType thread)
		{
			return null;
		}

		public static THREAD_AFFINITY ToFMODThreadAffinity(ThreadAffinity affinity)
		{
			return default(THREAD_AFFINITY);
		}

		private static void SetFMODAffinityBit(ThreadAffinity affinity, ThreadAffinity mask, THREAD_AFFINITY fmodMask, ref THREAD_AFFINITY fmodAffinity)
		{
		}

		public static void EnforceLibraryOrder()
		{
		}
	}
}
