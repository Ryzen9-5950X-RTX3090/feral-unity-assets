using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Movement To Object Tween", 0)]
	[Description("Creates a movement tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateMovementToObjectTween : ActionTask
	{
		[RequiredField]
		public BBParameter<GameObject> DestinationObject;

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
