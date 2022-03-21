using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[SpoofAOT]
	public static class IBlackboardExtensions
	{
		public static IBlackboard GetRoot(this IBlackboard blackboard)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<GetAllParents>d__1))]
		public static IEnumerable<IBlackboard> GetAllParents(this IBlackboard blackboard, bool includeSelf)
		{
			return null;
		}

		public static bool IsPartOf(this IBlackboard blackboard, IBlackboard target)
		{
			return default(bool);
		}

		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName, T value)
		{
			return null;
		}

		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName)
		{
			return null;
		}

		public static Variable AddVariable(this IBlackboard blackboard, string varName, object value)
		{
			return null;
		}

		public static Variable AddVariable(this IBlackboard blackboard, string varName, Type type)
		{
			return null;
		}

		public static Variable RemoveVariable(this IBlackboard blackboard, string varName)
		{
			return null;
		}

		public static T GetVariableValue<T>(this IBlackboard blackboard, string varName)
		{
			return (T)null;
		}

		public static Variable SetVariableValue(this IBlackboard blackboard, string varName, object value)
		{
			return null;
		}

		public static void InitializePropertiesBinding(this IBlackboard blackboard, Component target, bool callSetter)
		{
		}

		public static Variable<T> GetVariable<T>(this IBlackboard blackboard, string varName)
		{
			return null;
		}

		public static Variable GetVariable(this IBlackboard blackboard, string varName, [Optional] Type ofType)
		{
			return null;
		}

		public static Variable GetVariableByID(this IBlackboard blackboard, string ID)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<GetVariables>d__14))]
		public static IEnumerable<Variable> GetVariables(this IBlackboard blackboard, [Optional] Type ofType)
		{
			return null;
		}

		public static void OverwriteFrom(this IBlackboard blackboard, IBlackboard sourceBlackboard, bool removeMissingVariables = true)
		{
		}
	}
}
