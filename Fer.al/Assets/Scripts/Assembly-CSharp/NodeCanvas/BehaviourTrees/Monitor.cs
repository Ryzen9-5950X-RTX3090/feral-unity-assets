using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Category("Decorators")]
	[Icon("Eye", false, "")]
	[Description("Monitors the decorated child node for a returned Status and executes an Action when that is the case.\nThe final Status returned to the parent can either be the original Decorated Child Node Status, or the new Decorator Action Status.")]
	public class Monitor : BTDecorator, ITaskAssignable<ActionTask>, ITaskAssignable, IGraphElement
	{
		public enum MonitorMode
		{
			Failure = 0,
			Success = 1,
			AnyStatus = 10
		}

		public enum ReturnStatusMode
		{
			OriginalDecoratedChildStatus,
			NewDecoratorActionStatus
		}

		[Name("Monitor", 0)]
		public MonitorMode monitorMode;

		[Name("Return", 0)]
		public ReturnStatusMode returnMode;

		private Status decoratorActionStatus;

		[SerializeField]
		private ActionTask _action;

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

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected override void OnReset()
		{
		}
	}
}
