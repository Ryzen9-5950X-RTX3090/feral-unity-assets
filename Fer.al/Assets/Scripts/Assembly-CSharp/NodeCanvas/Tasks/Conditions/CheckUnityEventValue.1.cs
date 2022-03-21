using System;
using System.Reflection;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;
using UnityEngine.Events;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised and it's value is equal to provided value as well.")]
	public class CheckUnityEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<CheckUnityEventValue_0<T>>, IMigratable
	{
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo;

		[SerializeField]
		private BBParameter<T> checkValue;

		private UnityEvent<T> unityEvent;

		private MemberInfo targetMember
		{
			get
			{
				return null;
			}
		}

		private bool isStatic
		{
			get
			{
				return default(bool);
			}
		}

		private Type eventType
		{
			get
			{
				return null;
			}
		}

		private FieldInfo targetEventField
		{
			get
			{
				return null;
			}
		}

		private PropertyInfo targetEventProp
		{
			get
			{
				return null;
			}
		}

		public override Type agentType
		{
			get
			{
				return null;
			}
		}

		protected override string info
		{
			get
			{
				return null;
			}
		}

		void IMigratable<CheckUnityEventValue_0<T>>.Migrate(CheckUnityEventValue_0<T> model)
		{
		}

		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo()
		{
			return null;
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Raised(T eventValue)
		{
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}

		private void SetTargetEvent(MemberInfo newMember)
		{
		}
	}
}
