using System;
using System.Reflection;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Reflected/Events")]
	[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised.\n(eg public event System.Action<T> [name])")]
	public class CheckCSharpEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<CheckCSharpEvent_0<T>>, IMigratable, IMigratable<CheckStaticCSharpEvent<T>>
	{
		[SerializeField]
		private SerializedEventInfo eventInfo;

		[SerializeField]
		[BlackboardOnly]
		private BBParameter<T> saveAs;

		private Delegate handler;

		private EventInfo targetEvent
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

		void IMigratable<CheckCSharpEvent_0<T>>.Migrate(CheckCSharpEvent_0<T> model)
		{
		}

		void IMigratable<CheckStaticCSharpEvent<T>>.Migrate(CheckStaticCSharpEvent<T> model)
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

		private void SetTargetEvent(EventInfo info)
		{
		}
	}
}
