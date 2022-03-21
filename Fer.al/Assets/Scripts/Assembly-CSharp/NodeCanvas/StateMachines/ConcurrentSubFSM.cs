using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[Name("Parallel Sub FSM", -1)]
	[Description("Execute a Sub FSM in parallel and for as long as this FSM is running.")]
	[Category("SubGraphs")]
	[Color("ff64cb")]
	public class ConcurrentSubFSM : FSMNodeNested<FSM>, IUpdatable, IGraphElement
	{
		[SerializeField]
		[ExposeField]
		[Name("Parallel FSM", 0)]
		protected BBParameter<FSM> _subFSM;

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

		public override FSM subGraph
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

		public override void OnGraphStarted()
		{
		}

		void IUpdatable.Update()
		{
		}
	}
}
