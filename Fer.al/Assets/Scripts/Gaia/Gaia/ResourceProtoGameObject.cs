using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class ResourceProtoGameObject
	{
		[Tooltip("Resource name.")]
		public string m_name;

		[Tooltip("The game objects that will be instantiated when this is spawned.")]
		public ResourceProtoGameObjectInstance[] m_instances;

		[Tooltip("DNA - Used by the spawner to control how and where the game objects will be spawned.")]
		public ResourceProtoDNA m_dna;

		[Tooltip("SPAWN CRITERIA - Spawn criteria are run against the terrain to assess its fitness in a range of 0..1 for use by this resource. If you add multiple criteria then the fittest one will be selected.")]
		public SpawnCritera[] m_spawnCriteria;

		[Tooltip("SPAWN EXTENSIONS - Spawn extensions allow fitness, spawning and post spawning extensions to be made to the spawning system.")]
		public SpawnRuleExtension[] m_spawnExtensions;

		[Tooltip("Set this to true if you want this included in tree based spawner creation.")]
		public bool m_canSpawnAsTree;

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
