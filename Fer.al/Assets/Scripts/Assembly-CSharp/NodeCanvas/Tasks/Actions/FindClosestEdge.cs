using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Find Closest NavMesh Edge", 0)]
	[Category("Movement/Pathfinding")]
	[Description("Find the closes Navigation Mesh position to the target position")]
	public class FindClosestEdge : ActionTask
	{
		public BBParameter<Vector3> targetPosition;

		[BlackboardOnly]
		public BBParameter<Vector3> saveFoundPosition;

		private NavMeshHit hit;

		protected override void OnExecute()
		{
		}
	}
}
