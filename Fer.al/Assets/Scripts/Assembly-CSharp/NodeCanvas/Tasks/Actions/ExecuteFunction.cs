using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Execute Function (Desktop Only)", 10)]
	[Category("â\u009c« Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nExecute a function on a script, of up to 6 parameters and save the return if any. If function is an IEnumerator it will execute as a coroutine.")]
	public class ExecuteFunction : ActionTask, IReflectedWrapper
	{
		[SerializeField]
		protected ReflectedWrapper functionWrapper;

		private bool routineRunning;

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

		[IteratorStateMachine(typeof(<InternalCoroutine>d__13))]
		private IEnumerator InternalCoroutine(IEnumerator routine)
		{
			return null;
		}

		private void SetMethod(MethodInfo method)
		{
		}
	}
}
