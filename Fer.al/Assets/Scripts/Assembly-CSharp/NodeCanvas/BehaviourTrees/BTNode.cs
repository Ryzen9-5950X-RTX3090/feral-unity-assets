using System;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTNode : Node
	{
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

		public T AddChild<T>(int childIndex) where T : BTNode
		{
			return null;
		}

		public T AddChild<T>() where T : BTNode
		{
			return null;
		}
	}
}
