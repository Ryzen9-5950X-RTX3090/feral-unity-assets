using System;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Obsolete]
	public class GoToNode : DTNode
	{
		[SerializeField]
		private DTNode _targetNode;

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
