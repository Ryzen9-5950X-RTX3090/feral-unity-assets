using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.RigidBody
{
	[Category("DOTween/Tweens/RigidBody")]
	[Name("Create Look At Tween", 0)]
	[Description("Creates a rotation tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateLookAtTween : ActionTask<Rigidbody>
	{
		[RequiredField]
		public BBParameter<Vector3> LookAt;

		[RequiredField]
		public BBParameter<float> Duration;

		public AxisConstraint AxisConstraint;

		[BlackboardOnly]
		public BBParameter<Tween> CreatedTween;

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
