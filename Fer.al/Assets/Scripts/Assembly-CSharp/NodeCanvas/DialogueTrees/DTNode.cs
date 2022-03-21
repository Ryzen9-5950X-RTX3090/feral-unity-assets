using System;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public abstract class DTNode : Node
	{
		[SerializeField]
		private string _actorName;

		[SerializeField]
		private string _actorParameterID;

		public override string name
		{
			get
			{
				return null;
			}
		}

		public virtual bool requireActorSelection
		{
			get
			{
				return default(bool);
			}
		}

		public override int maxInConnections
		{
			get
			{
				return default(int);
			}
		}

		public override int maxOutConnections
		{
			get
			{
				return default(int);
			}
		}

		public sealed override Type outConnectionType
		{
			get
			{
				return null;
			}
		}

		public sealed override bool allowAsPrime
		{
			get
			{
				return default(bool);
			}
		}

		public sealed override bool canSelfConnect
		{
			get
			{
				return default(bool);
			}
		}

		public sealed override Alignment2x2 commentsAlignment
		{
			get
			{
				return default(Alignment2x2);
			}
		}

		public sealed override Alignment2x2 iconAlignment
		{
			get
			{
				return default(Alignment2x2);
			}
		}

		protected DialogueTree DLGTree
		{
			get
			{
				return null;
			}
		}

		public string actorName
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IDialogueActor finalActor
		{
			get
			{
				return null;
			}
		}
	}
}
