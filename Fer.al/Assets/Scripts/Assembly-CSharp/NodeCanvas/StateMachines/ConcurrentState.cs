using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[Name("Parallel", 0)]
	[Description("Execute a number of Actions with optional conditional requirement and in parallel to any other state, as soon as the FSM is started. All actions will prematurely be stoped as soon as the FSM stops as well. This is not a state per-se and thus can have neither incomming, nor outgoing transitions.")]
	[Color("ff64cb")]
	public class ConcurrentState : FSMNode, IUpdatable, IGraphElement
	{
		[SerializeField]
		private ConditionList _conditionList;

		[SerializeField]
		private ActionList _actionList;

		[SerializeField]
		private bool _repeatStateActions;

		private bool accessed;

		public ConditionList conditionList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ActionList actionList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool repeatStateActions
		{
			get
			{
				return default(bool);
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

		public override void OnValidate(Graph assignedGraph)
		{
		}

		public override void OnGraphStarted()
		{
		}

		public override void OnGraphStoped()
		{
		}

		public override void OnGraphPaused()
		{
		}

		void IUpdatable.Update()
		{
		}
	}
}
