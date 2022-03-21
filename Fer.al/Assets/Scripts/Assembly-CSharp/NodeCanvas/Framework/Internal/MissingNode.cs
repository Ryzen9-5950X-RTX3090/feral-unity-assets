using System;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal
{
	[DoNotList]
	[Description("Please resolve the MissingNode issue by either replacing the node, importing the missing node type, or refactoring the type in GraphRefactor.")]
	public sealed class MissingNode : Node, IMissingRecoverable
	{
		[SerializeField]
		private string _missingType;

		[SerializeField]
		private string _recoveryState;

		string IMissingRecoverable.missingType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		string IMissingRecoverable.recoveryState
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

		public override Type outConnectionType
		{
			get
			{
				return null;
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

		public override bool allowAsPrime
		{
			get
			{
				return default(bool);
			}
		}

		public override bool canSelfConnect
		{
			get
			{
				return default(bool);
			}
		}

		public override Alignment2x2 commentsAlignment
		{
			get
			{
				return default(Alignment2x2);
			}
		}

		public override Alignment2x2 iconAlignment
		{
			get
			{
				return default(Alignment2x2);
			}
		}
	}
}
