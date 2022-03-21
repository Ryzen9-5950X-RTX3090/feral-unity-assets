using System;
using System.Collections.Generic;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Check Function", 10)]
	[Category("â\u009c« Reflected")]
	[Description("Call a function on a component and return whether or not the return value is equal to the check value")]
	public class CheckFunction_Multiplatform : ConditionTask, IReflectedWrapper
	{
		[SerializeField]
		protected SerializedMethodInfo method;

		[SerializeField]
		protected List<BBObjectParameter> parameters;

		[SerializeField]
		protected CompareMethod comparison;

		[SerializeField]
		[BlackboardOnly]
		protected BBObjectParameter checkValue;

		private object[] args;

		private bool[] parameterIsByRef;

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
