using UnityEngine;

namespace Gaia
{
	public struct GaiaSplatPrototype
	{
		public float metallic;

		public Texture2D normalMap;

		public float smoothness;

		public Texture2D texture;

		public Vector2 tileOffset;

		public Vector2 tileSize;

		public GaiaSplatPrototype(TerrainLayer terrainLayer)
		{
		}

		public TerrainLayer Convert()
		{
			return null;
		}

		public static GaiaSplatPrototype[] GetGaiaSplatPrototypes(Terrain terrain)
		{
			return null;
		}

		public static void SetGaiaSplatPrototypes(Terrain terrain, GaiaSplatPrototype[] splats, string terrainName)
		{
		}

		private static TerrainLayer[] LookupTerrainLayerAssetFiles(string terrainName)
		{
			return null;
		}

		private static TerrainLayer SaveTerrainLayerAsAsset(string terrainName, string layerId, TerrainLayer terrainLayer)
		{
			return null;
		}

		private static void RemoveTerrainLayerAssetFiles(string terrainName)
		{
		}
	}
}
