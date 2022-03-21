using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Creates a burst of the specified gameobjects, which should be set up with collision, rigidbodies, pickup logic, etc...")]
	public class InstantiateBurstObjects : ActionTask<Transform>
	{
		public BBParameter<GameObject> gameObjectToSpawn;

		public BBParameter<int> numToSpawnMin;

		public BBParameter<int> numToSpawnMax;

		public BBParameter<float> burstForceMin;

		public BBParameter<float> burstForceMax;

		public BBParameter<float> timeToSpawn;

		public BBParameter<bool> waitToContinue;

		private float _spawnTime;

		private int _numToSpawn;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<Spawn>d__12))]
		private IEnumerator Spawn()
		{
			return null;
		}
	}
}
