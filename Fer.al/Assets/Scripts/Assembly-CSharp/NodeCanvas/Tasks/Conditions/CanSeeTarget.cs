using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTarget : ConditionTask<Transform>
	{
		[RequiredField]
		public BBParameter<GameObject> target;

		public BBParameter<float> maxDistance;

		public BBParameter<float> awarnessDistance;

		[SliderField(1, 180)]
		public BBParameter<float> viewAngle;

		public Vector3 offset;

		private RaycastHit hit;

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
