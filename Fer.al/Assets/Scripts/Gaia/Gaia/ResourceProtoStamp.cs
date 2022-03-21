using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class ResourceProtoStamp
	{
		[Tooltip("Stamp name.")]
		public string m_name;

		[Tooltip("Stamp texture.")]
		public Texture2D m_texture;

		[Tooltip("How far from the terrainâ\u0080\u0099s anchor point the tiling will start.")]
		public bool m_stickToGround;

		[Tooltip("DNA - Used by the spawner to control how and where the tree will be spawned.")]
		public ResourceProtoDNA m_dna;

		[Tooltip("SPAWN CRITERIA - Spawn criteria are run against the terrain to assess its fitness in a range of 0..1 for use by this resource. If you add multiple criteria then the fittest one will be selected.")]
		public SpawnCritera[] m_spawnCriteria;

		public void Initialise(Spawner spawner)
		{
		}

		public bool HasActiveCriteria()
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

		public void AddStamps(ref List<string> stampList)
		{
		}
	}
}
