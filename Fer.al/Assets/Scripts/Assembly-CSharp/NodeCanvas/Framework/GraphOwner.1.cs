using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public abstract class GraphOwner<T> : GraphOwner where T : Graph
	{
		[SerializeField]
		private T _graph;

		[SerializeField]
		private UnityEngine.Object _blackboard;

		public sealed override Graph graph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public T behaviour
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public sealed override IBlackboard blackboard
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public sealed override Type graphType
		{
			get
			{
				return null;
			}
		}

		public void StartBehaviour(T newGraph)
		{
		}

		public void StartBehaviour(T newGraph, Action<bool> callback)
		{
		}

		public void StartBehaviour(T newGraph, Graph.UpdateMode updateMode, [Optional] Action<bool> callback)
		{
		}

		public void SwitchBehaviour(T newGraph)
		{
		}

		public void SwitchBehaviour(T newGraph, Action<bool> callback)
		{
		}

		public void SwitchBehaviour(T newGraph, Graph.UpdateMode updateMode, [Optional] Action<bool> callback)
		{
		}
	}
}
