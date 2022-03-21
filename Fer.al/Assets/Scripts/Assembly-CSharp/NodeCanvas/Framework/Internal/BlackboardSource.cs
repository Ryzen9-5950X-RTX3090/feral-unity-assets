using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class BlackboardSource : IBlackboard
	{
		[SerializeField]
		private Dictionary<string, Variable> _variables;

		public string identifier
		{
			get
			{
				return null;
			}
		}

		public Dictionary<string, Variable> variables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IBlackboard parent
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

		public UnityEngine.Object unityContextObject
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

		public Component propertiesBindTarget
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

		string IBlackboard.independantVariablesFieldName
		{
			get
			{
				return null;
			}
		}

		public event Action<Variable> onVariableAdded
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

		public event Action<Variable> onVariableRemoved
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

		void IBlackboard.TryInvokeOnVariableAdded(Variable variable)
		{
		}

		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
