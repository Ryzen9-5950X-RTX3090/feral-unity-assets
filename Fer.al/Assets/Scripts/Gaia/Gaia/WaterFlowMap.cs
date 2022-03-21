using UnityEngine;

namespace Gaia
{
	public class WaterFlowMap
	{
		public float m_dropletVolume;

		public float m_dropletAbsorbtionRate;

		public int m_waterflowSmoothIterations;

		private UnityHeightMap m_heightMap;

		private HeightMap m_waterFlowMap;

		public void CreateWaterFlowMap(Terrain terrain)
		{
		}

		private void TraceWaterFlow(int startX, int startZ, int width, int height)
		{
		}

		public void ExportWaterMapToPath(string path)
		{
		}
	}
}
