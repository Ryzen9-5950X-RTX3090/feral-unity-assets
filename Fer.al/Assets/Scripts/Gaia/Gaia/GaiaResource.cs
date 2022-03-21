using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class GaiaResource : ScriptableObject
	{
		[HideInInspector]
		[Tooltip("Unique identifier for these resources.")]
		public string m_resourcesID;

		[Tooltip("Resource name")]
		public string m_name;

		[Tooltip("The absolute height of the sea or water table in meters. All spawn criteria heights are calculated relative to this. This can also be thought of as the water level. This value is sourced from the defaults file, and managed on a session by session basis.")]
		public float m_seaLevel;

		[Tooltip("The beach height in meters. Beaches are spawned at sea level and are extended for this height above sea level. This is used when creating default spawn rules in order to create a beach in the zone between water and land.")]
		public float m_beachHeight;

		[Tooltip("Terrain height.")]
		public float m_terrainHeight;

		[Tooltip("Texture prototypes and fitness criteria.")]
		public ResourceProtoTexture[] m_texturePrototypes;

		[Tooltip("Detail prototypes, dna and fitness criteria.")]
		public ResourceProtoDetail[] m_detailPrototypes;

		[Tooltip("Tree prototypes, dna and fitness criteria.")]
		public ResourceProtoTree[] m_treePrototypes;

		[Tooltip("Game object prototypes, dna and fitness criteria.")]
		public ResourceProtoGameObject[] m_gameObjectPrototypes;

		public bool SetAssetAssociations()
		{
			return default(bool);
		}

		public bool AssociateAssets()
		{
			return default(bool);
		}

		public void DeletePrototypes()
		{
		}

		public bool PrototypesMissingFromTerrain()
		{
			return default(bool);
		}

		public bool PrototypeMissingFromTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx)
		{
			return default(bool);
		}

		public int PrototypeIdxInTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx)
		{
			return default(int);
		}

		public bool ResourceIdxOutOfBounds(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx)
		{
			return default(bool);
		}

		public bool ResourceIsInUnity(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx)
		{
			return default(bool);
		}

		public void UpdatePrototypesFromTerrain()
		{
		}

		private string GetUniqueName(string name, ref Dictionary<string, string> names)
		{
			return null;
		}

		private void UpdateDNA(GameObject prefab, ref ResourceProtoDNA dna)
		{
		}

		public void ChangeHeight(float oldHeight, float newHeight)
		{
		}

		public void ChangeSeaLevel(float newSeaLevel)
		{
		}

		public void ChangeSeaLevel(float oldSeaLevel, float newSeaLevel)
		{
		}

		public void ApplyPrototypesToTerrain()
		{
		}

		public void ApplyPrototypesToTerrain(Terrain terrain)
		{
		}

		public void AddMissingPrototypesToTerrain()
		{
		}

		public void AddMissingPrototypesToTerrain(Terrain terrain)
		{
		}

		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx)
		{
		}

		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx, Terrain terrain)
		{
		}

		public bool ChecksTextures()
		{
			return default(bool);
		}

		public bool ChecksProximity()
		{
			return default(bool);
		}

		public void AddGameObject(GameObject prefab)
		{
		}

		public void AddGameObject(List<GameObject> prototypes)
		{
		}

		public GameObject CreateCoverageTextureSpawner(float range, float increment)
		{
			return null;
		}

		public GameObject CreateCoverageDetailSpawner(float range, float increment)
		{
			return null;
		}

		public GameObject CreateOrFindGaia()
		{
			return null;
		}

		public GameObject CreateOrFindSessionManager()
		{
			return null;
		}

		public GameObject CreateClusteredDetailSpawner(float range, float increment)
		{
			return null;
		}

		public GameObject CreateClusteredTreeSpawner(float range)
		{
			return null;
		}

		public GameObject CreateCoverageTreeSpawner(float range)
		{
			return null;
		}

		public GameObject CreateCoverageGameObjectSpawner(float range)
		{
			return null;
		}

		public GameObject CreateCoverageGameObjectSpawnerForTrees(float range)
		{
			return null;
		}

		public GameObject CreateClusteredGameObjectSpawner(float range)
		{
			return null;
		}

		public GameObject CreateClusteredGameObjectSpawnerForTrees(float range)
		{
			return null;
		}

		public void ExportTexture()
		{
		}

		public string SerialiseJson()
		{
			return null;
		}

		public void DeSerialiseJson(string json)
		{
		}
	}
}
