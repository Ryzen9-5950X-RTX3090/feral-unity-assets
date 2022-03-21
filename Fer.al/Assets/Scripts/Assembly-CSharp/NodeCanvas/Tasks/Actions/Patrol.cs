using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions
{
	[Category("Movement/Pathfinding")]
	[Description("Move Randomly or Progressively between various game object positions taken from the list provided")]
	public class Patrol : ActionTask<NavMeshAgent>
	{
		public enum PatrolMode
		{
			Progressive,
			Random
		}

		[RequiredField]
		public BBParameter<List<GameObject>> targetList;

		public BBParameter<PatrolMode> patrolMode;

		public BBParameter<float> speed;

		public BBParameter<float> keepDistance;

		private int index;

		private Vector3? lastRequest;

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

		protected override void OnUpdate()
		{
		}

		protected override void OnPause()
		{
		}

		protected override void OnStop()
		{
		}

		public override void OnDrawGizmosSelected()
		{
		}
	}
}
