using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.RigidBody
{
	[Category("DOTween/Tweens/RigidBody")]
	[Name("Create Movement To Position Tween", 0)]
	[Description("Creates a movement tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateMovementTween : ActionTask<Rigidbody>
	{
		[RequiredField]
		public BBParameter<Vector3> Destination;

		[RequiredField]
		public BBParameter<float> Duration;

		public BBParameter<bool> UseSnapping;

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
