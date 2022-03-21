using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[Name("Parallel Sub BehaviourTree", -1)]
	[Description("Execute a Sub Behaviour Tree in parallel and for as long as this FSM is running.")]
	[Category("SubGraphs")]
	[Color("ff64cb")]
	public class ConcurrentSubTree : FSMNodeNested<BehaviourTree>, IUpdatable, IGraphElement
	{
		[SerializeField]
		[ExposeField]
		[Name("Parallel Tree", 0)]
		protected BBParameter<BehaviourTree> _subTree;

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

		public override BehaviourTree subGraph
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
