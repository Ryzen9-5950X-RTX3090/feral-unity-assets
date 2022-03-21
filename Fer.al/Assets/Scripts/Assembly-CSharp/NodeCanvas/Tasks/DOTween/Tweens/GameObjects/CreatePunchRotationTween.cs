using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Punch Rotation Tween", 0)]
	[Description("Creates a punch rotation tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreatePunchRotationTween : ActionTask
	{
		[RequiredField]
		public BBParameter<Vector3> PunchRotation;

		[RequiredField]
		public BBParameter<float> Duration;

		public BBParameter<int> Vibration;

		public BBParameter<float> Elasticity;

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
