using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[Name("OnRoomJoin", 8)]
	[Category("WildWorks/Server")]
	[Description("Execute all child nodes once but simultaneously and return Success or Failure depending on the selected ParallelPolicy.\nIf set to Repeat, child nodes are repeated until the Policy set is met, or until all children have had a chance to complete at least once.")]
	[Icon("Sequencer", false, "")]
	[Color("bf7fff")]
	public class OnRoomJoin : BTComposite
	{
		private Status _status;

		private bool _initialized;

		private void AddListeners()
		{
		}

		private void RemoveListeners()
		{
		}

		protected override Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		private void Server_OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage)
		{
		}

		private void Server_OnRoomJoinFailed(RoomJoinFailedMessage inMessage)
		{
		}
	}
}
