using System;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.StateMachines
{
	public abstract class FSMNode : Node
	{
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

		public FSM FSM
		{
			get
			{
				return null;
			}
		}
	}
}
