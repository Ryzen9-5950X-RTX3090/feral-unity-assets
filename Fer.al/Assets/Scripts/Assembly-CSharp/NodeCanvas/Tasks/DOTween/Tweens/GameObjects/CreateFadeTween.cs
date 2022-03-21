using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Fade Tween", 0)]
	[Description("Creates a fade tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateFadeTween : ActionTask<Renderer>
	{
		[RequiredField]
		public BBParameter<float> Opacity;

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
