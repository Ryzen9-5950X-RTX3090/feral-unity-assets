using System;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Check Field", 8)]
	[Category("â\u009c« Reflected")]
	[Description("Check a field on a script and return if it's equal or not to a value")]
	public class CheckField : ConditionTask, IReflectedWrapper, IMigratable<CheckField_0>, IMigratable
	{
		[SerializeField]
		protected BBObjectParameter checkValue;

		[SerializeField]
		protected CompareMethod comparison;

		[SerializeField]
		protected SerializedFieldInfo field;

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

		void IMigratable<CheckField_0>.Migrate(CheckField_0 model)
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

		protected override bool OnCheck()
		{
			return default(bool);
		}

		private void SetTargetField(FieldInfo newField)
		{
		}
	}
}
