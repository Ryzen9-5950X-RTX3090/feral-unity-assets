using UnityEngine;

namespace Gaia
{
	public class SpawnRuleExtension : MonoBehaviour
	{
		public virtual void Initialise()
		{
		}

		public virtual bool AffectsTextures()
		{
			return default(bool);
		}

		public virtual bool AffectsDetails()
		{
			return default(bool);
		}

		public virtual float GetFitness(float fitness, ref SpawnInfo spawnInfo)
		{
			return default(float);
		}

		public virtual bool OverridesSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo)
		{
			return default(bool);
		}

		public virtual void Spawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo)
		{
		}

		public virtual void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo)
		{
		}
	}
}
