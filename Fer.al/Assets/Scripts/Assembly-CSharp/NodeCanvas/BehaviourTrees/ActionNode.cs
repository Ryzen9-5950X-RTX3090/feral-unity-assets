using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("Action", 0)]
	[Description("Executes an action and returns Success or Failure.\nReturns Running until the action is finished.")]
	[Icon("Action", false, "")]
	public class ActionNode : BTNode, ITaskAssignable<ActionTask>, ITaskAssignable, IGraphElement
	{
		[SerializeField]
		private ActionTask _action;

		public Task task
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ActionTask action
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string name
		{
			get
			{
				return null;
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}

		public override void OnGraphPaused()
		{
		}
	}
}
