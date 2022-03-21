using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Punch Position Tween", 0)]
	[Description("Creates a punch position tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreatePunchPositionTween : ActionTask
	{
		[RequiredField]
		public BBParameter<Vector3> PunchVector;

		[RequiredField]
		public BBParameter<float> Duration;

		public BBParameter<int> Vibration;

		public BBParameter<float> Elasticity;

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
