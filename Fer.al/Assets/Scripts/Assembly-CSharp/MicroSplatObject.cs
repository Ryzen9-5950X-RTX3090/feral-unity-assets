using System;
using UnityEngine;

[ExecuteAlways]
public class MicroSplatObject : MonoBehaviour
{
	public struct TerrainDescriptor
	{
		public Texture heightMap;

		public Texture normalMap;

		public Vector3 heightMapScale;
	}

	[HideInInspector]
	public Material templateMaterial;

	[NonSerialized]
	[HideInInspector]
	public Material matInstance;

	[HideInInspector]
	public Material blendMat;

	[HideInInspector]
	public Material blendMatInstance;

	[HideInInspector]
	public MicroSplatKeywords keywordSO;

	[HideInInspector]
	public Texture2D perPixelNormal;

	[HideInInspector]
	public Texture2D streamTexture;

	[HideInInspector]
	public MicroSplatPropData propData;

	protected long GetOverrideHash()
	{
		return default(long);
	}

	protected void SetMap(Material m, string name, Texture tex)
	{
	}

	protected void ApplySharedData(Material m)
	{
	}

	protected void ApplyMaps(Material m)
	{
	}

	protected void ApplyControlTextures(Texture2D[] controls, Material m)
	{
	}

	protected void SyncBlendMat(Vector3 size)
	{
	}

	public virtual TerrainDescriptor GetTerrainDescriptor()
	{
		return default(TerrainDescriptor);
	}

	public virtual Bounds GetBounds()
	{
		return default(Bounds);
	}

	public Material GetBlendMatInstance()
	{
		return null;
	}

	public void ApplyBlendMap()
	{
	}

	public void RevisionFromMat()
	{
	}

	public static void SyncAll()
	{
	}
}
