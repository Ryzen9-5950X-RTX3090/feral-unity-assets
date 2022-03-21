using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Lights
{
	[Category("DOTween/Tweens/Lights")]
	[Name("Create Shadow Strength Tween", 0)]
	[Description("Creates an intensity tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateShadowStrengthTween : ActionTask<Light>
	{
		[RequiredField]
		public BBParameter<float> ShadowStrength;

		[RequiredField]
		public BBParameter<float> Duration;

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
