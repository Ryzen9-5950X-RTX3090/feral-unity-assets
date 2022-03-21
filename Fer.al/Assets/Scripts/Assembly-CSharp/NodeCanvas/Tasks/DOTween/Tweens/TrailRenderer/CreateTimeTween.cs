using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.TrailRenderer
{
	[Category("DOTween/Tweens/TrailRenderer")]
	[Name("Create Time Tween", 0)]
	[Description("Creates a time tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateTimeTween : ActionTask<UnityEngine.TrailRenderer>
	{
		[RequiredField]
		public BBParameter<float> EndValue;

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
