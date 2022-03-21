using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Name("FINISH", 0)]
	[Category("Control")]
	[Description("End the dialogue in Success or Failure.\nNote: A Dialogue will anyway End in Succcess if it has reached a node without child connections. Thus this node is mostly useful if you want to end a Dialogue in Failure.")]
	[Icon("Halt", false, "")]
	[Color("00b9e8")]
	public class FinishNode : DTNode
	{
		public CompactStatus finishState;

		public override int maxOutConnections
		{
			get
			{
				return default(int);
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
	}
}
