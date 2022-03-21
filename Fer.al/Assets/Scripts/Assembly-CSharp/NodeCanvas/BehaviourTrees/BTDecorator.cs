using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTDecorator : BTNode
	{
		public sealed override int maxOutConnections
		{
			get
			{
				return default(int);
			}
		}

		public sealed override Alignment2x2 commentsAlignment
		{
			get
			{
				return default(Alignment2x2);
			}
		}

		protected Connection decoratedConnection
		{
			get
			{
				return null;
			}
		}

		protected Node decoratedNode
		{
			get
			{
				return null;
			}
		}
	}
}
