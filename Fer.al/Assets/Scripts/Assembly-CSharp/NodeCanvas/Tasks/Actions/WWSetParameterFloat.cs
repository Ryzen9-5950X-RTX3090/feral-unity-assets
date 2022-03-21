using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Set Parameter Float", 0)]
	[Category("WildWorks/Animator")]
	[Description("Sets an animator float parameter with an optional delay and transit time.")]
	public class WWSetParameterFloat : ActionTask<Animator>
	{
		public BBParameter<string> parameter;

		public BBParameter<float> setTo;

		public float delay;

		public float transitTime;

		public Interpolation.InterpolationType interpolationType;

		public bool waitForFinish;

		private float currentValue;

		private float myElapsedTime;

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

		[IteratorStateMachine(typeof(<ExecuteCoroutine>d__11))]
		private IEnumerator ExecuteCoroutine()
		{
			return null;
		}
	}
}
