using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.StateMachines
{
	[Name("Any State", 0)]
	[Description("The Transitions of this node will constantly be checked. If any becomes true, the target connected State will Enter regardless of the current State. This node can have no incomming transitions.")]
	[Color("b3ff7f")]
	public class AnyState : FSMNode, IUpdatable, IGraphElement
	{
		public bool dontRetriggerStates;

		public override string name
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

		public override void OnGraphStarted()
		{
		}

		public override void OnGraphStoped()
		{
		}

		void IUpdatable.Update()
		{
		}
	}
}
