using System;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class SpawnCritera
	{
		[Tooltip("Criteria name")]
		public string m_name;

		[Tooltip("CHECK TYPE - a single point on the terrain or area based. The size of the area checks is based on the Bounds Radius in the DNA. Area based checks are good for larger structures but substantially slower so use with care.")]
		public GaiaConstants.SpawnerLocationCheckType m_checkType;

		[Tooltip("When selected, the criteria will only be valid if the terrain was clear of any other objects at this location. A location is determined to be â\u0080\u0098virginâ\u0080\u0099 when raycast collision test hits clear terrain. To detect other objects at this location they must have colliders. You can use an invisible collider and this test to stop any resources that require virgin terrain from spawning at that location.")]
		public bool m_virginTerrain;

		[Tooltip("Whether or not this location will be checked for height.")]
		public bool m_checkHeight;

		[Tooltip("The minimum valid height relative to sea level. Only tested when Check Height is checked.")]
		public float m_minHeight;

		[Tooltip("The maximum valid height relative to sea level. Only tested when Check Height is checked.")]
		public float m_maxHeight;

		[Tooltip("The fitness curve - evaluated between the minimum and the maximum height when Check Height is checked. 0 is low fitness and unlikely to spawn, 1 is high fitness and likely to spawn.")]
		public AnimationCurve m_heightFitness;

		[Tooltip("Whether or not this location will be checked for slope.")]
		public bool m_checkSlope;

		[Tooltip("The minimum valid slope. Only tested when Check Slope is checked.")]
		public float m_minSlope;

		[Tooltip("The maximum valid slope. Only tested when Check Slope is checked.")]
		public float m_maxSlope;

		[Tooltip("The fitness curve - evaluated between the minimum and the maximum slope when Check Slope is checked. 0 is low fitness and unlikely to spawn, 1 is high fitness and likely to spawn.")]
		public AnimationCurve m_slopeFitness;

		[Tooltip("Whether or not to check proximity to other tags near this location.")]
		public bool m_checkProximity;

		[Tooltip("The tag that will be checked in proximity to this location e.g. House")]
		public string m_proximityTag;

		[Tooltip("The minimum valid proximity. Only tested when Check Proximity is checked.")]
		public float m_minProximity;

		[Tooltip("The maximum valid proximity. Only tested when Check Proximity is checked.")]
		public float m_maxProximity;

		[Tooltip("The fitness curve - evaluated between the minimum and the maximum proximity when Check Proximity is checked. 0 is low fitness and unlikely to spawn, 1 is high fitness and likely to spawn.")]
		public AnimationCurve m_proximityFitness;

		[Tooltip("Check textures at this location.")]
		public bool m_checkTexture;

		[Tooltip("Texture slots from your terrain (first valid slot is 0). Will select for presence that texture. Use exclamation mark in front of slot to select for absence of that texture. For example 3 selects for presence of texture 3, !3 checks for absence of texture 3. Fitness is based on the strength of the texture at that location in range 0..1. Only tested when Check Texture is checked.")]
		public string m_matchingTextures;

		[Tooltip("Whether or not this spawn criteria is active. It will be ignored if not active.")]
		public bool m_isActive;

		private bool m_isInitialised;

		public void Initialise(Spawner spawner)
		{
		}

		public float GetSlopeFitness(float slope)
		{
			return default(float);
		}

		public float GetHeightFitness(float height, float sealLevel)
		{
			return default(float);
		}

		public float GetProximityFitness(float proximity)
		{
			return default(float);
		}

		public float GetTextureFitness(float[] textures)
		{
			return default(float);
		}

		public float GetFitness(ref SpawnInfo spawnInfo)
		{
			return default(float);
		}
	}
}
