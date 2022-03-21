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
	[Description("Will subscribe to a public UnityEvent and return true when that event is raised.")]
	public class CheckUnityEvent : ConditionTask, IReflectedWrapper, IMigratable<CheckUnityEvent_0>, IMigratable
	{
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo;

		private UnityEvent unityEvent;

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

		void IMigratable<CheckUnityEvent_0>.Migrate(CheckUnityEvent_0 model)
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

		public void Raised()
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
