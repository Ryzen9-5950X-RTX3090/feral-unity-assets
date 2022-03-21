using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Target In View Angle", 0)]
	[Category("GameObject")]
	[Description("Checks whether the target is in the view angle of the agent")]
	public class IsInFront : ConditionTask<Transform>
	{
		[RequiredField]
		public BBParameter<GameObject> checkTarget;

		[SliderField(1, 180)]
		public BBParameter<float> viewAngle;

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

		public override void OnDrawGizmosSelected()
		{
		}
	}
}
