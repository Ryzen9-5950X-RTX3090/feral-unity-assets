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
	[Description("Set a variable on a script")]
	[Name("Set Field", 5)]
	public class SetField : ActionTask, IReflectedWrapper, IMigratable<SetField_0>, IMigratable
	{
		[SerializeField]
		protected SerializedFieldInfo field;

		[SerializeField]
		protected BBObjectParameter setValue;

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

		void IMigratable<SetField_0>.Migrate(SetField_0 model)
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
