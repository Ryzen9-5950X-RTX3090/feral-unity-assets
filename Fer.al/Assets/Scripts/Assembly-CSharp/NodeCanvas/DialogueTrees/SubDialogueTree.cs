using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Name("Sub Dialogue Tree", 0)]
	[Description("Execute a Sub Dialogue Tree. When that Dialogue Tree is finished, this node will continue either in Success or Failure if it has any connections. Useful for making reusable and self-contained Dialogue Trees.")]
	[DropReferenceType(typeof(DialogueTree))]
	public class SubDialogueTree : DTNodeNested<DialogueTree>, IUpdatable, IGraphElement
	{
		[SerializeField]
		[ExposeField]
		private BBParameter<DialogueTree> _subTree;

		[fsSerializeAs]
		private Dictionary<string, string> _actorParametersMap;

		public override int maxOutConnections
		{
			get
			{
				return default(int);
			}
		}

		public override DialogueTree subGraph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override BBParameter subGraphParameter
		{
			get
			{
				return null;
			}
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		private void OnSubDialogueFinish(bool success)
		{
		}

		void IUpdatable.Update()
		{
		}

		private void TryWriteMappedActorParameters()
		{
		}
	}
}
