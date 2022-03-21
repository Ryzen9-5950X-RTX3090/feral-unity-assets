using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsUninitialized]
	[SpoofAOT]
	public abstract class Variable
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private string _id;

		[SerializeField]
		private bool _isPublic;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ID
		{
			get
			{
				return null;
			}
		}

		public object value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isExposedPublic
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isPropertyBound
		{
			get
			{
				return default(bool);
			}
		}

		public abstract bool isDataBound { get; }

		public abstract Type varType { get; }

		public abstract string propertyPath { get; set; }

		public event Action<string> onNameChanged
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

		public event Action<object> onValueChanged
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

		public event Action onDestroy
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

		public abstract void BindProperty(MemberInfo prop, [Optional] GameObject target);

		public abstract void UnBind();

		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

		public abstract object GetValueBoxed();

		public abstract void SetValueBoxed(object value);

		public Variable()
		{
		}

		internal void OnDestroy()
		{
		}

		public Variable Duplicate(IBlackboard targetBB)
		{
			return null;
		}

		protected bool HasValueChangeEvent()
		{
			return default(bool);
		}

		protected void TryInvokeValueChangeEvent(object value)
		{
		}

		public bool CanConvertTo(Type toType)
		{
			return default(bool);
		}

		public Func<object> GetGetConverter(Type toType)
		{
			return null;
		}

		public bool CanConvertFrom(Type fromType)
		{
			return default(bool);
		}

		public Action<object> GetSetConverter(Type fromType)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
