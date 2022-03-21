using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[GraphInfo]
	[CreateAssetMenu]
	public class FSM : Graph
	{
		public enum TransitionCallMode
		{
			Normal,
			Stacked,
			Clean
		}

		private List<IUpdatable> updatableNodes;

		private IStateCallbackReceiver[] callbackReceivers;

		private Stack<FSMState> stateStack;

		public FSMState currentState
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FSMState previousState
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string currentStateName
		{
			get
			{
				return null;
			}
		}

		public string previousStateName
		{
			get
			{
				return null;
			}
		}

		public override Type baseNodeType
		{
			get
			{
				return null;
			}
		}

		public override bool requiresAgent
		{
			get
			{
				return default(bool);
			}
		}

		public override bool requiresPrimeNode
		{
			get
			{
				return default(bool);
			}
		}

		public override bool isTree
		{
			get
			{
				return default(bool);
			}
		}

		public override bool allowBlackboardOverrides
		{
			get
			{
				return default(bool);
			}
		}

		public sealed override bool canAcceptVariableDrops
		{
			get
			{
				return default(bool);
			}
		}

		public event Action<IState> onStateEnter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IState> onStateUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IState> onStateExit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IState> onStateTransition
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void OnGraphInitialize()
		{
		}

		protected override void OnGraphStarted()
		{
		}

		protected override void OnGraphUpdate()
		{
		}

		protected override void OnGraphStoped()
		{
		}

		public bool EnterState(FSMState newState, TransitionCallMode callMode)
		{
			return default(bool);
		}

		public FSMState TriggerState(string stateName, TransitionCallMode callMode)
		{
			return null;
		}

		public string[] GetStateNames()
		{
			return null;
		}

		public FSMState GetStateWithName(string name)
		{
			return null;
		}

		private void GatherCallbackReceivers()
		{
		}

		public FSMState PeekStack()
		{
			return null;
		}
	}
}
