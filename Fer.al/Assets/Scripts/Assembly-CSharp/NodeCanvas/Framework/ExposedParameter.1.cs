using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public sealed class ExposedParameter<T> : ExposedParameter
	{
		[SerializeField]
		private string _targetVariableID;

		[SerializeField]
		private T _value;

		public Variable<T> varRef
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

		public override string targetVariableID
		{
			get
			{
				return null;
			}
		}

		public override Type type
		{
			get
			{
				return null;
			}
		}

		public override object valueBoxed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Variable varRefBoxed
		{
			get
			{
				return null;
			}
		}

		public T value
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		public ExposedParameter()
		{
		}

		public ExposedParameter(Variable target)
		{
		}

		public override void Bind(IBlackboard blackboard)
		{
		}

		public override void UnBind(IBlackboard blackboard)
		{
		}

		private T GetRawValue()
		{
			return (T)null;
		}

		private void SetRawValue(T value)
		{
		}
	}
}
