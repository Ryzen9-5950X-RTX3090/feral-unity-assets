using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public class Variable<T> : Variable
	{
		[SerializeField]
		private T _value;

		[SerializeField]
		private string _propertyPath;

		public override Type varType
		{
			get
			{
				return null;
			}
		}

		public override bool isDataBound
		{
			get
			{
				return default(bool);
			}
		}

		public override string propertyPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public void SetValue(T newValue)
		{
		}

		public override void BindProperty(MemberInfo prop, [Optional] GameObject target)
		{
		}

		public void BindGetSet(Func<T> _get, Action<T> _set)
		{
		}

		public override void UnBind()
		{
		}

		public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
		{
		}
	}
}
