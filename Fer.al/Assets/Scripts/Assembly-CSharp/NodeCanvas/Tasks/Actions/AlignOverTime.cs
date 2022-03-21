using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Aligns a tansform to another transform")]
	public class AlignOverTime : ActionTask<Transform>
	{
		public BBParameter<Transform> targetTransform;

		public BBParameter<float> duration;

		public BBParameter<bool> waitToContinue;

		public BBParameter<bool> movingTargetTransform;

		public BBParameter<bool> ParentWhenComplete;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<Align>d__8))]
		private IEnumerator Align()
		{
			return null;
		}
	}
}
