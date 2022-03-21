using System;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Reflected")]
	[Description("Get a variable of a script and save it to the blackboard")]
	[Name("Get Field", 6)]
	public class GetField : ActionTask, IReflectedWrapper, IMigratable<GetField_0>, IMigratable
	{
		[SerializeField]
		protected SerializedFieldInfo field;

		[SerializeField]
		[BlackboardOnly]
		protected BBObjectParameter saveAs;

		private FieldInfo targetField
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

		void IMigratable<GetField_0>.Migrate(GetField_0 model)
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

		protected override void OnExecute()
		{
		}

		private void SetTargetField(FieldInfo newField)
		{
		}
	}
}
