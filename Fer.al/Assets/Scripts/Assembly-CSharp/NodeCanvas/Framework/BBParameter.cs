using System;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT]
	[fsUninitialized]
	[fsAutoInstance(true)]
	public abstract class BBParameter : ISerializationCollectable, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private string _targetVariableID;

		private IBlackboard _bb;

		private Variable _varRef;

		public string targetVariableID
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Variable varRef
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

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

		public IBlackboard bb
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useBlackboard
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isPresumedDynamic
		{
			get
			{
				return default(bool);
			}
		}

		public bool isNone
		{
			get
			{
				return default(bool);
			}
		}

		public bool isNull
		{
			get
			{
				return default(bool);
			}
		}

		public bool isNoneOrNull
		{
			get
			{
				return default(bool);
			}
		}

		public bool isDefined
		{
			get
			{
				return default(bool);
			}
		}

		public Type refType
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

		public abstract Type varType { get; }

		public event Action<Variable> onVariableReferenceChanged
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

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public BBParameter()
		{
		}

		public static BBParameter CreateInstance(Type t, IBlackboard bb)
		{
			return null;
		}

		public static void SetBBFields(object target, IBlackboard bb)
		{
		}

		protected abstract void SetDefaultValue();

		protected abstract void Bind(Variable data);

		public abstract object GetValueBoxed();

		public abstract void SetValueBoxed(object value);

		internal void SetTargetVariable(IBlackboard targetBB, Variable targetVariable)
		{
		}

		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID)
		{
			return null;
		}

		public Variable PromoteToVariable(IBlackboard targetBB)
		{
			return null;
		}

		public sealed override string ToString()
		{
			return null;
		}
	}
}
