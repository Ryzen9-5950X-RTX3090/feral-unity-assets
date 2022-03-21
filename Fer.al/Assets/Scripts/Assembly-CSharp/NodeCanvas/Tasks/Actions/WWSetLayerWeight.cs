using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Set Layer Weight", 0)]
	[Category("WildWorks/Animator")]
	[Description("Sets an animator layer weight with an optional delay and transit time.")]
	public class WWSetLayerWeight : ActionTask<Animator>
	{
		public BBParameter<int> layerIndex;

		[SliderField(0, 1)]
		public BBParameter<float> layerWeight;

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
