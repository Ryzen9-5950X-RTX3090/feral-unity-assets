using System;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Obsolete]
	[Category("â\u009c« Blackboard")]
	[Obsolete("Use CheckVariable(T)")]
	public class CheckUnityObject : ConditionTask
	{
		[BlackboardOnly]
		public BBParameter<UnityEngine.Object> valueA;

		public BBParameter<UnityEngine.Object> valueB;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
