using System.Collections.Generic;
using UnityEngine;

public static class CoreGameObjectExtensions
{
	public static T GetOrAddComponent<T>(this GameObject inGameObject) where T : Component
	{
		return null;
	}

	public static bool HasComponent<T>(this GameObject inGameObject) where T : Component
	{
		return default(bool);
	}

	public static void SetParent(this GameObject inGameObject, GameObject inParent)
	{
	}

	public static void SafeDestroy(this GameObject inGameObject)
	{
	}

	public static void SetLayerRecursively(this GameObject inGO, int inLayer)
	{
	}

	public static List<GameObject> GetGameObjectsWithLayer(this GameObject inGO, int inLayer, bool inExcludeInLayer = false)
	{
		return null;
	}

	public static bool IsPrefab(this GameObject inGO)
	{
		return default(bool);
	}
}
