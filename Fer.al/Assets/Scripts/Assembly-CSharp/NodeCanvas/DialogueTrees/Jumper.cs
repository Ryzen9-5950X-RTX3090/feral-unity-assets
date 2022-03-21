using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Name("JUMP", 0)]
	[Description("Select a target node to jump to.\nFor your convenience in identifying nodes in the dropdown, please give a Tag name to the nodes you want to use in this way.")]
	[Category("Control")]
	[Icon("Set", false, "")]
	[Color("00b9e8")]
	public class Jumper : DTNode, IHaveNodeReference, IGraphElement
	{
		[fsSerializeAs]
		public NodeReference<DTNode> _targetNode;

		INodeReference IHaveNodeReference.targetReference
		{
			get
			{
				return null;
			}
		}

		private DTNode target
		{
			get
			{
				return null;
			}
		}

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
