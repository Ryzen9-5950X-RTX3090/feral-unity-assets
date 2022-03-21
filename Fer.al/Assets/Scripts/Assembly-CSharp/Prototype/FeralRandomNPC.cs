using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace Prototype
{
	public class FeralRandomNPC : ManagedBehaviour
	{
		[RootSelector("Avatar", "AvatarChartData", false, false)]
		public string npcAvatarDefId;

		[SerializeField]
		private float _disableRange;

		[SerializeField]
		private bool _disableOffScreen;

		[SerializeField]
		private float _modelScale;

		private NavMeshAgent _agent;

		private ActorBase _actorBase;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<CreateRandomActor>d__7))]
		private IEnumerator CreateRandomActor()
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
