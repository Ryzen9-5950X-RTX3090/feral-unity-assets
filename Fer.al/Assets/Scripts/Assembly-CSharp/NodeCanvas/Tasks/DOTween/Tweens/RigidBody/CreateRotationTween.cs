using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.RigidBody
{
	[Category("DOTween/Tweens/RigidBody")]
	[Name("Create Rotation Tween", 0)]
	[Description("Creates a rotation tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateRotationTween : ActionTask<Rigidbody>
	{
		[RequiredField]
		public BBParameter<Vector3> Rotation;

		[RequiredField]
		public BBParameter<float> Duration;

		public RotateMode RotateMode;

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
