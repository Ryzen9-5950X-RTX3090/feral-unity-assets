using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Blackboard")]
	public class SampleCurve : ActionTask
	{
		[RequiredField]
		public BBParameter<AnimationCurve> curve;

		[SliderField(0, 1)]
		public BBParameter<float> sampleAt;

		[BlackboardOnly]
		public BBParameter<float> saveAs;

		protected override void OnExecute()
		{
		}
	}
}
