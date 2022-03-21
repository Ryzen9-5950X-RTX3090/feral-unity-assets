using UnityEngine;

namespace Gaia
{
	public class SpawnTextureExtension : SpawnRuleExtension
	{
		[Tooltip("The zero based index of the terrain texture to be applied.")]
		public int m_textureIndex;

		[Tooltip("The mask used to display this texture.")]
		public Texture2D m_textureMask;

		[Tooltip("Whether or not to normalise the mask. Normalisation allows the full dynamic range of the mask to be used.")]
		public bool m_normaliseMask;

		[Tooltip("Whether or not to invert the mask.")]
		public bool m_invertMask;

		[Tooltip("Whether or not to flip the mask.")]
		public bool m_flipMask;

		[Tooltip("The mask scale with respect to the areas bounds of this spawn.")]
		[Range(0.1f, 10f)]
		public float m_scaleMask;

		private UnityHeightMap m_textureHM;

		public override void Initialise()
		{
		}

		public override bool AffectsTextures()
		{
			return default(bool);
		}

		public override void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo)
		{
		}
	}
}
