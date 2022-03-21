using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	public abstract class FSMState : FSMNode, IState
	{
		public enum TransitionEvaluationMode
		{
			CheckContinuously,
			CheckAfterStateFinished,
			CheckManually
		}

		[SerializeField]
		private TransitionEvaluationMode _transitionEvaluation;

		private bool _hasInit;

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

		public TransitionEvaluationMode transitionEvaluation
		{
			get
			{
				return default(TransitionEvaluationMode);
			}
			set
			{
			}
		}

		public FSMConnection[] GetTransitions()
		{
			return null;
		}

		public void Finish()
		{
		}

		public void Finish(bool inSuccess)
		{
		}

		public void Finish(Status status)
		{
		}

		public override void OnGraphPaused()
		{
		}

		protected override bool CanConnectFromSource(Node sourceNode)
		{
			return default(bool);
		}

		protected override bool CanConnectToTarget(Node targetNode)
		{
			return default(bool);
		}

		protected sealed override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		public void Update()
		{
		}

		public bool CheckTransitions()
		{
			return default(bool);
		}

		protected sealed override void OnReset()
		{
		}

		protected virtual void OnInit()
		{
		}

		protected virtual void OnEnter()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnExit()
		{
		}

		protected virtual void OnPause()
		{
		}
	}
}
