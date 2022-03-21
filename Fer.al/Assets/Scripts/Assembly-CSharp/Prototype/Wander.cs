using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.AI;

namespace Prototype
{
	public class Wander : ManagedBehaviour
	{
		private NavMeshAgent _agent;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<Navigate>d__2))]
		private IEnumerator Navigate()
		{
			return null;
		}
	}
}
