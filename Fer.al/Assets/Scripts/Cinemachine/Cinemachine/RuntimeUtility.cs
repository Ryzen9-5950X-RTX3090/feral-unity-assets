using System.Runtime.InteropServices;
using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	public static class RuntimeUtility
	{
		private static RaycastHit[] s_HitBuffer;

		private static int[] s_PenetrationIndexBuffer;

		private static SphereCollider s_ScratchCollider;

		private static GameObject s_ScratchColliderGameObject;

		public static void DestroyObject(Object obj)
		{
		}

		public static bool IsPrefab(GameObject gameObject)
		{
			return default(bool);
		}

		public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, [In] ref string ignoreTag)
		{
			return default(bool);
		}

		public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, [In] ref string ignoreTag)
		{
			return default(bool);
		}

		internal static SphereCollider GetScratchCollider()
		{
			return null;
		}

		internal static void DestroyScratchCollider()
		{
		}
	}
}
