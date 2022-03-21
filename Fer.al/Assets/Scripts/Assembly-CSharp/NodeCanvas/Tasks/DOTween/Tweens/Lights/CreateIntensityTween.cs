using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Lights
{
	[Category("DOTween/Tweens/Lights")]
	[Name("Create Intensity Tween", 0)]
	[Description("Creates an intensity tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateIntensityTween : ActionTask<Light>
	{
		[RequiredField]
		public BBParameter<float> Intensity;

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
