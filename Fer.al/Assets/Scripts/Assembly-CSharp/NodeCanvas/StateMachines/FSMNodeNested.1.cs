using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.StateMachines
{
	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FSMNodeNested<T> : FSMNode, IGraphAssignable<T>, IGraphAssignable, IGraphElement where T : Graph
	{
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;

		public abstract T subGraph { get; set; }

		public abstract BBParameter subGraphParameter { get; }

		public T currentInstance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<Graph, Graph> instances
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<BBMappingParameter> variablesMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Graph IGraphAssignable.subGraph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Graph IGraphAssignable.currentInstance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
