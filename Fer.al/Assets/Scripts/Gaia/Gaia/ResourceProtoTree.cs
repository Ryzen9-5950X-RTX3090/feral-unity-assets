using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class ResourceProtoTree
	{
		[Tooltip("Resource name.")]
		public string m_name;

		[Tooltip("Desktop prefab.")]
		public GameObject m_desktopPrefab;

		[HideInInspector]
		public string m_desktopPrefabFileName;

		[Tooltip("Mobile prefab - future proofing here - not currently used.")]
		public GameObject m_mobilePrefab;

		[HideInInspector]
		public string m_mobilePrefabFileName;

		[Tooltip("How much the tree bends in the wind - only used by unity tree creator trees, ignored by SpeedTree trees.")]
		public float m_bendFactor;

		[Tooltip("The colour of healthy trees - only used by unity tree creator trees, ignored by SpeedTree trees.")]
		public Color m_healthyColour;

		[Tooltip("The colour of dry trees - only used by unity tree creator trees, ignored by SpeedTree trees.")]
		public Color m_dryColour;

		[Tooltip("DNA - Used by the spawner to control how and where the tree will be spawned.")]
		public ResourceProtoDNA m_dna;

		[Tooltip("SPAWN CRITERIA - Spawn criteria are run against the terrain to assess its fitness in a range of 0..1 for use by this resource. If you add multiple criteria then the fittest one will be selected.")]
		public SpawnCritera[] m_spawnCriteria;

		[Tooltip("SPAWN EXTENSIONS - Spawn extensions allow fitness, spawning and post spawning extensions to be made to the spawning system.")]
		public SpawnRuleExtension[] m_spawnExtensions;

		public void Initialise(Spawner spawner)
		{
		}

		public bool HasActiveCriteria()
		{
			return default(bool);
		}

		public bool SetAssetAssociations()
		{
			return default(bool);
		}

		public bool AssociateAssets()
		{
			return default(bool);
		}

		public bool ChecksTextures()
		{
			return default(bool);
		}

		public bool ChecksProximity()
		{
			return default(bool);
		}

		public void AddTags(ref List<string> tagList)
		{
		}
	}
}
