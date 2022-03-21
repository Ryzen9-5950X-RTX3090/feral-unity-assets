using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

namespace Gaia
{
	[ExecuteInEditMode]
	public class Spawner : MonoBehaviour
	{
		private class SpawnLocation
		{
			public Vector3 m_location;

			public float m_seedDistance;
		}

		[fsIgnore]
		public GaiaResource m_resources;

		public string m_resourcesPath;

		public string m_spawnerID;

		public GaiaConstants.OperationMode m_mode;

		public int m_seed;

		public GaiaConstants.SpawnerShape m_spawnerShape;

		public GaiaConstants.SpawnerRuleSelector m_spawnRuleSelector;

		public GaiaConstants.SpawnerLocation m_spawnLocationAlgorithm;

		public GaiaConstants.SpawnerLocationCheckType m_spawnLocationCheckType;

		public float m_locationIncrement;

		public float m_maxJitteredLocationOffsetPct;

		public int m_locationChecksPerInt;

		public int m_maxRandomClusterSize;

		public float m_spawnRange;

		public AnimationCurve m_spawnFitnessAttenuator;

		public GaiaConstants.ImageFitnessFilterMode m_areaMaskMode;

		public bool m_enableColliderCacheAtRuntime;

		public Texture2D m_imageMask;

		public bool m_imageMaskInvert;

		public bool m_imageMaskNormalise;

		public bool m_imageMaskFlip;

		public int m_imageMaskSmoothIterations;

		[fsIgnore]
		public HeightMap m_imageMaskHM;

		private FractalGenerator m_noiseGenerator;

		public float m_noiseMaskSeed;

		public int m_noiseMaskOctaves;

		public float m_noiseMaskPersistence;

		public float m_noiseMaskFrequency;

		public float m_noiseMaskLacunarity;

		public float m_noiseZoom;

		public bool m_noiseInvert;

		public float m_spawnInterval;

		public string m_triggerTags;

		public float m_triggerRange;

		public List<SpawnRule> m_spawnerRules;

		public LayerMask m_spawnCollisionLayers;

		public int m_spawnColliderLayer;

		public bool m_showGizmos;

		public bool m_showDebug;

		public bool m_showStatistics;

		public bool m_showTerrainHelper;

		public XorshiftPlus m_rndGenerator;

		private bool m_cacheDetails;

		private Dictionary<int, List<HeightMap>> m_detailMapCache;

		private bool m_cacheTextures;

		private bool m_textureMapsDirty;

		private Dictionary<int, List<HeightMap>> m_textureMapCache;

		private bool m_cacheTags;

		private Dictionary<string, Quadtree<GameObject>> m_taggedGameObjectCache;

		public TreeManager m_treeCache;

		private bool m_cacheHeightMaps;

		private bool m_heightMapDirty;

		private Dictionary<int, UnityHeightMap> m_heightMapCache;

		private Dictionary<string, HeightMap> m_stampCache;

		[fsIgnore]
		public GameObject m_areaBoundsColliderCache;

		[fsIgnore]
		public GameObject m_goColliderCache;

		[fsIgnore]
		public GameObject m_goParentGameObject;

		private bool m_cancelSpawn;

		public int m_totalRuleCnt;

		public int m_activeRuleCnt;

		public int m_inactiveRuleCnt;

		public ulong m_maxInstanceCnt;

		public ulong m_activeInstanceCnt;

		public ulong m_inactiveInstanceCnt;

		public ulong m_totalInstanceCnt;

		private float m_terrainHeight;

		private float m_checkDistance;

		private RaycastHit m_checkHitInfo;

		public IEnumerator m_updateCoroutine;

		public float m_updateTimeAllowed;

		public float m_spawnProgress;

		public bool m_spawnComplete;

		public Bounds m_spawnerBounds;

		private bool m_isTextureSpawner;

		private bool m_isDetailSpawner;

		private bool m_isTreeSpawnwer;

		private bool m_isGameObjectSpawner;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void StartEditorUpdates()
		{
		}

		public void StopEditorUpdates()
		{
		}

		private void EditorUpdate()
		{
		}

		private void Start()
		{
		}

		public void Initialise()
		{
		}

		private void PreSpawnInitialise()
		{
		}

		public void SetUpSpawnerTypeFlags()
		{
		}

		public void AssociateAssets()
		{
		}

		public int[] GetMissingResources()
		{
			return null;
		}

		public void AddResourcesToTerrain(int[] rules)
		{
		}

		private void PostSpawn()
		{
		}

		public bool IsTextureSpawner()
		{
			return default(bool);
		}

		public bool IsDetailSpawner()
		{
			return default(bool);
		}

		public bool IsTreeSpawner()
		{
			return default(bool);
		}

		public bool IsGameObjectSpawner()
		{
			return default(bool);
		}

		public void ResetSpawner()
		{
		}

		public void CancelSpawn()
		{
		}

		public bool IsSpawning()
		{
			return default(bool);
		}

		private bool CanSpawnInstances()
		{
			return default(bool);
		}

		public void RunSpawnerIteration()
		{
		}

		[IteratorStateMachine(typeof(<RunRandomSpawnerIteration>d__100))]
		public IEnumerator RunRandomSpawnerIteration()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<RunAreaSpawnerIteration>d__101))]
		public IEnumerator RunAreaSpawnerIteration()
		{
			return null;
		}

		public void GroundToTerrain()
		{
		}

		public void FitToTerrain()
		{
		}

		public bool IsFitToTerrain()
		{
			return default(bool);
		}

		public bool LoadImageMask()
		{
			return default(bool);
		}

		public void CreateSpawnCaches()
		{
		}

		public void CreateSpawnCaches(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx)
		{
		}

		public void DeleteSpawnCaches(bool flushDirty = false)
		{
		}

		public bool TryExecuteRule(ref SpawnRule rule, ref SpawnInfo spawnInfo)
		{
			return default(bool);
		}

		public bool CheckLocation(Vector3 locationWU, ref SpawnInfo spawnInfo)
		{
			return default(bool);
		}

		public bool CheckLocationBounds(ref SpawnInfo spawnInfo, float distance)
		{
			return default(bool);
		}

		public void UpdateCounters()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public void CacheTextureMapsFromTerrain(int terrainID)
		{
		}

		public List<HeightMap> GetTextureMaps(int terrainID)
		{
			return null;
		}

		public void SaveTextureMapsToTerrain(int terrainID)
		{
		}

		public void DeleteTextureMapCache()
		{
		}

		public void SetTextureMapsDirty()
		{
		}

		public void CacheDetailMapsFromTerrain(int terrainID)
		{
		}

		public void SaveDetailMapsToTerrain(int terrainID)
		{
		}

		public List<HeightMap> GetDetailMaps(int terrainID)
		{
			return null;
		}

		public HeightMap GetDetailMap(int terrainID, int detailIndex)
		{
			return null;
		}

		public void DeleteDetailMapCache()
		{
		}

		public void CacheTreesFromTerrain()
		{
		}

		public void DeleteTreeCache()
		{
		}

		public void AddToSession(GaiaOperation.OperationType opType, string opName)
		{
		}

		public string SerialiseJson()
		{
			return null;
		}

		public void DeSerialiseJson(string json)
		{
		}

		public void FlattenTerrain()
		{
		}

		public void SmoothTerrain()
		{
		}

		public void ClearTrees()
		{
		}

		public void ClearDetails()
		{
		}

		public void CacheHeightMapFromTerrain(int terrainID)
		{
		}

		public UnityHeightMap GetHeightMap(int terrainID)
		{
			return null;
		}

		public void SaveHeightMapToTerrain(int terrainID)
		{
		}

		public void DeleteHeightMapCache()
		{
		}

		public void SetHeightMapsDirty()
		{
		}

		public void CacheStamps(List<string> stampList)
		{
		}

		private void CacheTaggedGameObjectsFromScene(List<string> tagList)
		{
		}

		private void DeleteTagCache()
		{
		}

		public List<GameObject> GetNearbyObjects(List<string> tagList, Rect area)
		{
			return null;
		}

		public GameObject GetClosestObject(List<string> tagList, Rect area)
		{
			return null;
		}

		public GameObject GetClosestObject(string tag, Rect area)
		{
			return null;
		}

		public void ResetRandomGenertor()
		{
		}

		public int GetRandomInt(int min, int max)
		{
			return default(int);
		}

		public float GetRandomFloat(float min, float max)
		{
			return default(float);
		}

		public Vector3 GetRandomV3(float range)
		{
			return default(Vector3);
		}
	}
}
