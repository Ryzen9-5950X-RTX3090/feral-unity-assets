using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Scales a transform over a specified time")]
	public class ScaleMultiplyOverTime : ActionTask<Transform>
	{
		public bool useScaleAmountForLocalScale;

		public BBParameter<float> scaleAmount;

		public BBParameter<float> duration;

		public BBParameter<bool> waitToContinue;

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

		[IteratorStateMachine(typeof(<Scale>d__7))]
		private IEnumerator Scale()
		{
			return null;
		}
	}
}
