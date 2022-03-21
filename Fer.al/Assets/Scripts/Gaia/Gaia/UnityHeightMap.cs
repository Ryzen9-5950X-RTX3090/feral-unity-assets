using UnityEngine;

namespace Gaia
{
	public class UnityHeightMap : HeightMap
	{
		public Bounds m_boundsWU;

		public UnityHeightMap()
		{
		}

		public UnityHeightMap(string path)
		{
		}

		public UnityHeightMap(TextAsset source)
		{
		}

		public UnityHeightMap(UnityHeightMap source)
		{
		}

		public UnityHeightMap(Terrain terrain)
		{
		}

		public UnityHeightMap(Bounds bounds, string sourceFile)
		{
		}

		public UnityHeightMap(Texture2D texture)
		{
		}

		public Bounds GetBoundsWU()
		{
			return default(Bounds);
		}

		public Vector3 GetPositionWU()
		{
			return default(Vector3);
		}

		public void SetBoundsWU(Bounds bounds)
		{
		}

		public void SetPositionWU(Vector3 position)
		{
		}

		public void LoadFromTerrain(Terrain terrain)
		{
		}

		public void SaveToTerrain(Terrain terrain)
		{
		}

		public void LoadFromTexture2D(Texture2D texture)
		{
		}

		public void ReadRawFromTextAsset(TextAsset asset)
		{
		}

		public Texture2D CalculateNormals()
		{
			return null;
		}
	}
}
