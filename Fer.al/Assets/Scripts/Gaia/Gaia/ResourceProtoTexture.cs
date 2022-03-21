using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class ResourceProtoTexture
	{
		[Tooltip("Resource name.")]
		public string m_name;

		[Tooltip("Resource texture.")]
		public Texture2D m_texture;

		[HideInInspector]
		public string m_textureFileName;

		[Tooltip("Resource normal.")]
		public Texture2D m_normal;

		[HideInInspector]
		public string m_normalFileName;

		[Tooltip("The width over which the image will stretch on the terrainâ\u0080\u0099s surface.")]
		public float m_sizeX;

		[Tooltip("The height over which the image will stretch on the terrainâ\u0080\u0099s surface.")]
		public float m_sizeY;

		[Tooltip("How far from the terrainâ\u0080\u0099s anchor point the tiling will start.")]
		public float m_offsetX;

		[Tooltip("How far from the terrainâ\u0080\u0099s anchor point the tiling will start.")]
		public float m_offsetY;

		[Tooltip("Controls the overall metalness of the surface.")]
		[Range(0f, 1f)]
		public float m_metalic;

		[Tooltip("Controls the overall smoothness of the surface.")]
		[Range(0f, 1f)]
		public float m_smoothness;

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
