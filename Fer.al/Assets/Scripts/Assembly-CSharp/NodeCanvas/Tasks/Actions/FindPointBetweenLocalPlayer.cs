using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Player")]
	[Description("Finds a point between local player and agent at the specified scaler.")]
	public class FindPointBetweenLocalPlayer : ActionTask<Transform>
	{
		[SliderField(0f, 1f)]
		public BBParameter<float> scaler;

		public BBParameter<Vector3> resultPoint;

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
	}
}
