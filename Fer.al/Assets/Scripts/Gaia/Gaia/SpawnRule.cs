using System;
using System.Collections.Generic;
using Gaia.FullSerializer;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class SpawnRule
	{
		public string m_name;

		public bool m_useExtendedSpawn;

		public float m_minViableFitness;

		public float m_failureRate;

		public ulong m_maxInstances;

		public bool m_ignoreMaxInstances;

		public float m_minDirection;

		public float m_maxDirection;

		public GaiaConstants.SpawnerResourceType m_resourceType;

		public int m_resourceIdx;

		[fsIgnore]
		public int m_resourceIdxPhysical;

		[fsIgnore]
		public Transform m_spawnParent;

		[fsIgnore]
		public string m_colliderName;

		public GaiaConstants.NoiseType m_noiseMask;

		public float m_noiseMaskSeed;

		public int m_noiseMaskOctaves;

		public float m_noiseMaskPersistence;

		public float m_noiseMaskFrequency;

		public float m_noiseMaskLacunarity;

		public float m_noiseZoom;

		public float m_noiseStrength;

		public bool m_noiseInvert;

		private FractalGenerator m_noiseGenerator;

		public bool m_isActive;

		public bool m_isFoldedOut;

		public ulong m_currInstanceCnt;

		public ulong m_activeInstanceCnt;

		public ulong m_inactiveInstanceCnt;

		public void Initialise(Spawner spawner)
		{
		}

		public bool ResourceIsInUnity(Spawner spawner)
		{
			return default(bool);
		}

		public bool ResourceIsLoadedInTerrain(Spawner spawner)
		{
			return default(bool);
		}

		public void AddResourceToTerrain(Spawner spawner)
		{
		}

		public float GetFitness(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		public float GetRadius(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		public float GetSeedThrowRange(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		public void Spawn(ref SpawnInfo spawnInfo)
		{
		}

		public bool CacheHeightMaps(Spawner spawner)
		{
			return default(bool);
		}

		public bool CacheTextures(Spawner spawner)
		{
			return default(bool);
		}

		public bool CacheDetails(Spawner spawner)
		{
			return default(bool);
		}

		public bool CacheProximity(Spawner spawner)
		{
			return default(bool);
		}

		public void AddProximityTags(Spawner spawner, ref List<string> tagList)
		{
		}
	}
}
