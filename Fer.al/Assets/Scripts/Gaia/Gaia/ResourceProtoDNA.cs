using System;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class ResourceProtoDNA
	{
		[Tooltip("Width in world units.")]
		public float m_width;

		[Tooltip("Height in world units.")]
		public float m_height;

		[Tooltip("Radius from centre of object in world units for bounded area checks. Make this larger if you want more free space around your object when it is spawned.")]
		public float m_boundsRadius;

		[Tooltip("The maximum distance a seed can be thrown when a new instance is spawned. Used to control spread area random clustered spawning.")]
		public float m_seedThrow;

		[Tooltip("The minimum scale that this can be rendered into the world. For terrain details this is the minimum strength that detail will render at.")]
		public float m_minScale;

		[Tooltip("The maximum scale that this can be rendered into the world. For terrain details this is the maximum strength that detail will render at.")]
		public float m_maxScale;

		[Tooltip("Randomise the scale somewhere between minimum and maximum scale. If not selected then the scale will be proportionally influenced by the locations fitness.")]
		public bool m_rndScaleInfluence;

		[Tooltip("Custom parameter to be interpreted by an extension if there is one. Use 'nograss' to exclude grass being grown within the volumne covered by the area bounds.")]
		public string m_extParam;

		[HideInInspector]
		public int m_protoIdx;

		public void Update(int protoIdx)
		{
		}

		public void Update(int protoIdx, float width, float height)
		{
		}

		public void Update(int protoIdx, float width, float height, float minscale, float maxscale)
		{
		}

		public float GetScale(float fitness)
		{
			return default(float);
		}

		public float GetScale(float fitness, float random)
		{
			return default(float);
		}
	}
}
