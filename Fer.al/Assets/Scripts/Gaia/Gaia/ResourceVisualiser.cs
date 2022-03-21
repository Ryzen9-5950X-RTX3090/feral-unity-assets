using System;
using UnityEngine;

namespace Gaia
{
	public class ResourceVisualiser : MonoBehaviour
	{
		[Tooltip("Choose the resources - these are the resources that will be managed.")]
		public GaiaResource m_resources;

		[Tooltip("Visualiser range - controls how far the visualiser extends. Make smaller on lower powered computers.")]
		public float m_range;

		[Tooltip("Visualiser resolution. Make larger on lower powered computers.")]
		[Range(3f, 50f)]
		public float m_resolution;

		[Tooltip("Minimum fitness - points with fitness less than this value will not be shown.")]
		[Range(0f, 1f)]
		public float m_minimumFitness;

		[Tooltip("Controls which layers are checked for collisions. Must at least include the layer the terrain is on. Add additional layers if other collisions need to be detected as well. Influences terrain detection, tree detection and game object detection.")]
		public LayerMask m_fitnessCollisionLayers;

		[Tooltip("Colour of high fitness locations.")]
		public Color m_fitColour;

		[Tooltip("Colour of low fitness locations.")]
		public Color m_unfitColour;

		[HideInInspector]
		public Spawner m_spawner;

		[HideInInspector]
		public Vector3 m_lastHitPoint;

		[HideInInspector]
		public string m_lastHitObjectname;

		[HideInInspector]
		public float m_lastHitFitness;

		[HideInInspector]
		public float m_lastHitHeight;

		[HideInInspector]
		public float m_lastHitTerrainHeight;

		[HideInInspector]
		public float m_lastHitTerrainRelativeHeight;

		[HideInInspector]
		public float m_lastHitTerrainSlope;

		[HideInInspector]
		public float m_lastHitAreaSlope;

		[HideInInspector]
		public bool m_lastHitWasVirgin;

		[HideInInspector]
		public GaiaConstants.SpawnerResourceType m_selectedResourceType;

		[HideInInspector]
		public int m_selectedResourceIdx;

		[HideInInspector]
		private DateTime m_lastUpdateDate;

		[HideInInspector]
		private DateTime m_lastCacheUpdateDate;

		private UnityHeightMap m_terrainHeightMap;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialise()
		{
		}

		public void Visualise()
		{
		}

		public SpawnInfo GetSpawnInfo(Vector3 location)
		{
			return null;
		}

		public float GetFitness(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		public float GetMinFitness(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		private void OnDrawGizmos()
		{
		}
	}
}
