using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	public class BBParameter<T> : BBParameter
	{
		[SerializeField]
		protected T _value;

		public new T value
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		public override Type varType
		{
			get
			{
				return null;
			}
		}

		private event Func<T> getter
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

		private event Action<T> setter
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

		public BBParameter()
		{
		}

		public BBParameter(T value)
		{
		}

		public override object GetValueBoxed()
		{
			return null;
		}

		public override void SetValueBoxed(object newValue)
		{
		}

		public T GetValue()
		{
			return (T)null;
		}

		public void SetValue(T value)
		{
		}

		protected override void SetDefaultValue()
		{
		}

		protected override void Bind(Variable variable)
		{
		}

		private bool BindGetter(Variable variable)
		{
			return default(bool);
		}

		private bool BindSetter(Variable variable)
		{
			return default(bool);
		}

		public static implicit operator BBParameter<T>(T value)
		{
			return null;
		}
	}
}
