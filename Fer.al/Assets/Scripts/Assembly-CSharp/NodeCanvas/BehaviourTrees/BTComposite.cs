using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTComposite : BTNode
	{
		public override string name
		{
			get
			{
				return null;
			}
		}

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
	}
}
