using System;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[GraphInfo]
	[CreateAssetMenu]
	public class BehaviourTree : Graph
	{
		[Serializable]
		private class DerivedSerializationData
		{
			public bool repeat;

			public float updateInterval;
		}

		[NonSerialized]
		public bool repeat;

		[NonSerialized]
		public float updateInterval;

		private float intervalCounter;

		private Status _rootStatus;

		public Status rootStatus
		{
			get
			{
				return default(Status);
			}
			private set
			{
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

		public static event Action<BehaviourTree, Status> onRootStatusChanged
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

		public override object OnDerivedDataSerialization()
		{
			return null;
		}

		public override void OnDerivedDataDeserialization(object data)
		{
		}

		protected override void OnGraphStarted()
		{
		}

		protected override void OnGraphUpdate()
		{
		}

		private Status Tick(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}
	}
}
