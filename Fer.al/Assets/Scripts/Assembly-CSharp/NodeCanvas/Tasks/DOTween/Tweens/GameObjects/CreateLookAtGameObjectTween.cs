using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Look At Game Objec Tween", 0)]
	[Description("Creates a look at tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateLookAtGameObjectTween : ActionTask<Rigidbody>
	{
		[RequiredField]
		public BBParameter<GameObject> LookAtObject;

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
