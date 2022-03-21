using System;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Check Property", 9)]
	[Category("â\u009c« Reflected")]
	[Description("Check a property on a script and return if it's equal or not to the check value")]
	public class CheckProperty_Multiplatform : ConditionTask, IReflectedWrapper
	{
		[SerializeField]
		protected SerializedMethodInfo method;

		[SerializeField]
		protected BBObjectParameter checkValue;

		[SerializeField]
		protected CompareMethod comparison;

		private MethodInfo targetMethod
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

		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo()
		{
			return null;
		}

		public override void OnValidate(ITaskSystem ownerSystem)
		{
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}

		private void SetMethod(MethodInfo method)
		{
		}
	}
}
