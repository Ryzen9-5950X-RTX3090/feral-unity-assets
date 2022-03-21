using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Name("Task Action", 0)]
	[Description("Execute an Action Task for the Dialogue Actor selected.")]
	public class ActionNode : DTNode, ITaskAssignable<ActionTask>, ITaskAssignable, IGraphElement
	{
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

		public override bool requireActorSelection
		{
			get
			{
				return default(bool);
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		[IteratorStateMachine(typeof(<UpdateAction>d__10))]
		private IEnumerator UpdateAction(Component actionAgent)
		{
			return null;
		}

		private void OnActionEnd(bool success)
		{
		}

		protected override void OnReset()
		{
		}

		public override void OnGraphPaused()
		{
		}
	}
}
