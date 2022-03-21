using UnityEngine;

namespace Gaia
{
	public class TerrainHelper : MonoBehaviour
	{
		[Range(1f, 5f)]
		[Tooltip("Number of smoothing interations to run. Can be run multiple times.")]
		public int m_smoothIterations;

		private void Awake()
		{
		}

		public static void Flatten()
		{
		}

		public static void FlattenTerrain(Terrain terrain)
		{
		}

		public static void FlattenTerrain(Terrain[] terrains)
		{
		}

		public static void Stitch()
		{
		}

		public static void StitchTerrains(Terrain[] terrains)
		{
		}

		public void Smooth()
		{
		}

		public static void Smooth(int iterations)
		{
		}

		public static Vector3 GetActiveTerrainCenter(bool flushToGround = true)
		{
			return default(Vector3);
		}

		public static Terrain GetActiveTerrain()
		{
			return null;
		}

		public static LayerMask GetActiveTerrainLayer()
		{
			return default(LayerMask);
		}

		public static LayerMask GetActiveTerrainLayerAsInt()
		{
			return default(LayerMask);
		}

		public static int GetActiveTerrainCount()
		{
			return default(int);
		}

		public static Terrain GetTerrain(Vector3 locationWU)
		{
			return null;
		}

		public static bool GetTerrainBounds(Terrain terrain, ref Bounds bounds)
		{
			return default(bool);
		}

		public static bool GetTerrainBounds(Vector3 locationWU, ref Bounds bounds)
		{
			return default(bool);
		}

		public static Vector3 GetRandomPositionOnTerrain(Terrain terrain, Vector3 start, float radius)
		{
			return default(Vector3);
		}

		public static void ClearTrees()
		{
		}

		public static void ClearDetails()
		{
		}

		public static float GetRangeFromTerrain()
		{
			return default(float);
		}
	}
}
