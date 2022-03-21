using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions
{
	[Category("Movement/Pathfinding")]
	[Description("Makes the agent wander randomly within the navigation map")]
	public class Wander : ActionTask<NavMeshAgent>
	{
		public BBParameter<float> speed;

		public BBParameter<float> keepDistance;

		public BBParameter<float> minWanderDistance;

		public BBParameter<float> maxWanderDistance;

		public bool repeat;

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void DoWander()
		{
		}

		protected override void OnPause()
		{
		}

		protected override void OnStop()
		{
		}
	}
}
