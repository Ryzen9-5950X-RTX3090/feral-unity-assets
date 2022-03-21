using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Rotation Tween", 0)]
	[Description("Creates a rotation tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateRotationTween : ActionTask
	{
		public BBParameter<Vector3> DestinationRotation;

		public BBParameter<GameObject> DestinationGameObject;

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
