using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Lean.Pool
{
	public static class LeanPool
	{
		public const string HelpUrlPrefix = "https://carloswilkes.github.io/Documentation/LeanPool#";

		public const string ComponentPathPrefix = "Lean/Pool/Lean ";

		public static Dictionary<GameObject, LeanGameObjectPool> Links;

		public static T Spawn<T>(T prefab, [Optional] Transform parent, bool worldPositionStays = false) where T : Component
		{
			return null;
		}

		public static T Spawn<T>(T prefab, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool worldPositionStays = true) where T : Component
		{
			return null;
		}

		public static GameObject Spawn(GameObject prefab, [Optional] Transform parent, bool worldPositionStays = false)
		{
			return null;
		}

		public static GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool worldPositionStays = true)
		{
			return null;
		}

		public static void DespawnAll()
		{
		}

		public static void Despawn(Component clone, float delay = 0f)
		{
		}

		public static void Despawn(GameObject clone, float delay = 0f)
		{
		}
	}
}
