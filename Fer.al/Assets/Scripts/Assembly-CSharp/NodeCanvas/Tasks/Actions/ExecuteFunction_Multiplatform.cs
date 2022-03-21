using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Execute Function", 10)]
	[Category("â\u009c« Reflected")]
	[Description("Execute a function on a script and save the return if any.\nIf function is an IEnumerator it will execute as a coroutine.")]
	public class ExecuteFunction_Multiplatform : ActionTask, IReflectedWrapper
	{
		[SerializeField]
		protected SerializedMethodInfo method;

		[SerializeField]
		protected List<BBObjectParameter> parameters;

		[SerializeField]
		[BlackboardOnly]
		protected BBObjectParameter returnValue;

		private object[] args;

		private bool routineRunning;

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

		protected override void OnExecute()
		{
		}

		protected override void OnStop()
		{
		}

		[IteratorStateMachine(typeof(<InternalCoroutine>d__17))]
		private IEnumerator InternalCoroutine(IEnumerator routine)
		{
			return null;
		}

		private void SetMethod(MethodInfo method)
		{
		}
	}
}
