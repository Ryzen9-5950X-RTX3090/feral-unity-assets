using UnityEngine;

namespace Gaia
{
	public class GaiaWorldManager
	{
		private Bounds m_worldBoundsWU;

		private Vector3 m_worldBoundsWUMin;

		private Vector3 m_worldBoundsWUMax;

		private Vector3 m_worldBoundsWUSize;

		private Bounds m_worldBoundsTU;

		private Vector3 m_worldBoundsTUMin;

		private Vector3 m_worldBoundsTUMax;

		private Vector3 m_worldBoundsTUSize;

		private Bounds m_worldBoundsNU;

		private Vector3 m_worldBoundsNUMin;

		private Vector3 m_worldBoundsNUMax;

		private Vector3 m_WUtoTU;

		private Vector3 m_TUtoWU;

		private Vector3 m_TUtoNU;

		private Vector3 m_NUtoTU;

		private Vector3 m_WUtoNU;

		private Vector3 m_NUtoWU;

		private Vector3 m_NUZeroOffset;

		private Vector3 m_TUZeroOffset;

		private ulong m_boundsCheckErrors;

		private Terrain[,] m_physicalTerrainArray;

		private UnityHeightMap[,] m_heightMapTerrainArray;

		private int m_tileCount;

		public int TileCount
		{
			get
			{
				return default(int);
			}
		}

		public Terrain[,] PhysicalTerrainArray
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityHeightMap[,] HeightMapTerrainArray
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Bounds WorldBoundsWU
		{
			get
			{
				return default(Bounds);
			}
		}

		public Bounds WorldBoundsTU
		{
			get
			{
				return default(Bounds);
			}
		}

		public Bounds WorldBoundsNU
		{
			get
			{
				return default(Bounds);
			}
		}

		public Vector3 WUtoTUConversionFactor
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 WUtoNUConversionFactor
		{
			get
			{
				return default(Vector3);
			}
		}

		public ulong BoundsCheckErrors
		{
			get
			{
				return default(ulong);
			}
			set
			{
			}
		}

		public GaiaWorldManager()
		{
		}

		public GaiaWorldManager(Terrain[] terrains)
		{
		}

		public string IsValidWorld(Terrain[] terrains)
		{
			return null;
		}

		private Terrain GetTerrainWU(Vector3 positionWU)
		{
			return null;
		}

		private Terrain GetTerrainTU(Vector3 positionTU)
		{
			return null;
		}

		private Terrain GetTerrainNU(Vector3 positionNU)
		{
			return null;
		}

		private UnityHeightMap GetHeightMapWU(Vector3 positionWU)
		{
			return null;
		}

		private UnityHeightMap GetHeightMapTU(Vector3 positionTU)
		{
			return null;
		}

		private UnityHeightMap GetHeightMapNU(Vector3 positionNU)
		{
			return null;
		}

		public void LoadFromWorld()
		{
		}

		public void SaveToWorld(bool forceWrite = false)
		{
		}

		public void SetHeightWU(float heightWU)
		{
		}

		public void SetHeightWU(Vector3 positionWU, float height)
		{
		}

		public float GetHeightWU(Vector3 positionWU)
		{
			return default(float);
		}

		public float GetHeightInterpolatedWU(Vector3 positionWU)
		{
			return default(float);
		}

		public void SetHeightTU(Vector3 positionTU, float height)
		{
		}

		public float GetHeightTU(Vector3 positionTU)
		{
			return default(float);
		}

		public float GetHeightInterpolatedTU(Vector3 positionTU)
		{
			return default(float);
		}

		public void FlattenWorld()
		{
		}

		public void SmoothWorld()
		{
		}

		public void ExportWorldAsPng(string path)
		{
		}

		public void ExportSplatmapAsPng(string path, int textureIdx)
		{
		}

		public void ExportGrassmapAsPng(string path)
		{
		}

		public void ExportNormalmapAsPng(string path)
		{
		}

		public void ExportNormalmapAsPng1(string path)
		{
		}

		public void ExportWaterflowMapAsPng(int iterations, string path)
		{
		}

		public void ExportShorelineMask(string path, float shoreHeightWU, float shoreWidthWU)
		{
		}

		private void MakeMask(Vector3 positionTU, float shoreHeightNU, float maskSizeTU, HeightMap waterMask)
		{
		}

		public bool InBoundsWU(Vector3 positionWU)
		{
			return default(bool);
		}

		public bool InBoundsTU(Vector3 positionTU)
		{
			return default(bool);
		}

		public bool InBoundsNU(Vector3 positionNU)
		{
			return default(bool);
		}

		public Vector3 WUtoTU(Vector3 positionWU)
		{
			return default(Vector3);
		}

		public Vector3 WUtoNU(Vector3 positionWU)
		{
			return default(Vector3);
		}

		public Vector3 WUtoPTI(Vector3 positionWU)
		{
			return default(Vector3);
		}

		public Vector3 WUtoPTO(Vector3 positionWU)
		{
			return default(Vector3);
		}

		public Vector3 TUtoWU(Vector3 positionTU)
		{
			return default(Vector3);
		}

		public Vector3 TUtoNU(Vector3 positionTU)
		{
			return default(Vector3);
		}

		public void TUtoPTI(ref Vector3 positionTU)
		{
		}

		public void TUtoPTO(ref Vector3 positionTU)
		{
		}

		public Vector3 NUtoWU(Vector3 positionNU)
		{
			return default(Vector3);
		}

		public Vector3 NUtoTU(Vector3 positionNU)
		{
			return default(Vector3);
		}

		public void NUtoPTI(ref Vector3 positionNU)
		{
		}

		public void NUtoPTO(ref Vector3 positionNU)
		{
		}

		public Vector3 Ceil(Vector3 source)
		{
			return default(Vector3);
		}

		public Vector3 Floor(Vector3 source)
		{
			return default(Vector3);
		}

		public void Test()
		{
		}

		public void TestBlobWU(Vector3 positionWU, int widthWU, float height)
		{
		}

		public void TestBlobTU(Vector3 positionTU, int widthWU, float height)
		{
		}
	}
}
