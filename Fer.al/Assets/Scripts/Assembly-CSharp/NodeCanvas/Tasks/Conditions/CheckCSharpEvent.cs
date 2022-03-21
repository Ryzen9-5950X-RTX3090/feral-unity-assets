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
	[Description("Will subscribe to a public event of Action type and return true when the event is raised.\n(eg public event System.Action [name])")]
	public class CheckCSharpEvent : ConditionTask, IReflectedWrapper, IMigratable<CheckCSharpEvent_0>, IMigratable, IMigratable<CheckStaticCSharpEvent>
	{
		[SerializeField]
		private SerializedEventInfo eventInfo;

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

		void IMigratable<CheckCSharpEvent_0>.Migrate(CheckCSharpEvent_0 model)
		{
		}

		void IMigratable<CheckStaticCSharpEvent>.Migrate(CheckStaticCSharpEvent model)
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

		private void SetTargetEvent(EventInfo info)
		{
		}
	}
}
