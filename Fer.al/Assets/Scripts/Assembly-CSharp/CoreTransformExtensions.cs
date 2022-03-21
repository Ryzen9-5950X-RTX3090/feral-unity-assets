using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class CoreTransformExtensions
{
	private static List<Transform> _splitMaterialsTracked;

	public static string GetPath(this Transform current)
	{
		return null;
	}

	public static void SetParentAndResetToZero(this Transform inTransform, Transform inParent)
	{
	}

	public static void ResetToZero(this Transform inTransform)
	{
	}

	public static Transform FindChildByName(this Transform inParent, string inFindName, bool inExcludeParent = false, bool inExactName = false, bool inCaseSensitive = false)
	{
		return null;
	}

	public static Transform FindRootParent(this Transform inParent)
	{
		return null;
	}

	public static Transform FindParentContainingName(this Transform inParent, string inName)
	{
		return null;
	}

	public static Transform FindSkinnedMeshObject(this Transform inParent, bool InExcludeParent = false)
	{
		return null;
	}

	public static Transform FindSkinnedMeshObjectContainingName(this Transform inParent, string inContaining, bool InExcludeParent = false)
	{
		return null;
	}

	public static List<Transform> FindChildrenByName(this Transform inParent, string[] inName)
	{
		return null;
	}

	public static void SetLayer(this Transform InParent, int InLayer)
	{
	}

	public static void SetStatic(this Transform InParent, bool InStatic)
	{
	}

	public static void SetAllChildColors(this Transform inParent, string inMatParam, Color inColor, bool inShared = true)
	{
	}

	public static void SplitAllMaterialsTracked(this Transform inParent)
	{
	}

	public static void SplitAllMaterials(this Transform inParent)
	{
	}

	public static void DisableGlobalAmbientColor(this Transform inParent, bool inForceDisable = false)
	{
	}

	public static List<Material> GetAllMaterials(this Transform inParent, string inShaderName = "")
	{
		return null;
	}

	public static void SetTexture(this Transform inParent, string inMatParam, Texture2D inTexture)
	{
	}

	public static void SetAllChildTextures(this Transform inParent, string inMatParam, Texture2D inTexture)
	{
	}

	public static T GetChildComponentOfType<T>(this Transform inTransform) where T : Component
	{
		return null;
	}

	public static List<T> GetAllComponentsOfType<T>(this Transform inParent) where T : Component
	{
		return null;
	}

	public static List<MeshCollider> GetAllChildMeshColliders(this Transform inParent, bool inVerifyRigidbody = false)
	{
		return null;
	}

	public static T GetComponentInParentWW<T>(this Transform inParent) where T : Component
	{
		return null;
	}

	public static List<Transform> GetAllChildTransforms(this Transform inParent)
	{
		return null;
	}

	public static List<T> GetAllComponentsInChildren<T>(this Transform inParent)
	{
		return null;
	}

	public static void SetAllChildShaders(this Transform inParent, Shader inShader, [Optional] string inIgnoreName)
	{
	}

	public static void SetAllChildShaderLODs(this Transform inParent, int inLOD, [Optional] string inIgnoreName)
	{
	}

	public static void SetAllChildShaderColor(this Transform inParent, string inColorName, Color inColor, [Optional] string inIgnoreName)
	{
	}

	public static void SetAllChildShaderKeywords(this Transform inParent, string[] inEnableKeywords, string[] inDisableKeywords, [Optional] string inIgnoreName)
	{
	}

	public static void SetAllChildMultiShaderQuality(this Transform inParent, AssetQualityLevel inQuality)
	{
	}

	public static void SetAllChildMultiShaderDirty(this Transform inParent, bool inEnabled)
	{
	}

	public static void SetAllChildMultiShaderKeyword(this Transform inParent, string inEnableKeyword, string inDisableKeyword, [Optional] string inIgnoreName)
	{
	}

	public static void SetAllChildShaders(this Transform inParent, string inShader)
	{
	}

	public static void ReplaceAllChildShaders(this Transform inParent, string inReplaceShader, string inShader)
	{
	}

	public static void SetRecursiveEmission(this Transform inParent, bool inEnabled)
	{
	}

	public static void SetActiveFXRecursively(this Transform inParent, bool active)
	{
	}

	public static void SetParentUI(this Transform inTransform, Transform inParent)
	{
	}

	public static void Clear(this Transform inTransform)
	{
	}

	public static float AngleTo(this Transform inTransform, Transform inOther)
	{
		return default(float);
	}

	public static float AngleTo(this Transform inTransform, Vector3 inPosition)
	{
		return default(float);
	}
}
