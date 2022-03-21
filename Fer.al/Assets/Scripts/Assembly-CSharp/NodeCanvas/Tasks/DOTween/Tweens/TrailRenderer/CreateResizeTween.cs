using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.TrailRenderer
{
	[Category("DOTween/Tweens/TrailRenderer")]
	[Name("Create Resize Tween", 0)]
	[Description("Creates a colour tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateResizeTween : ActionTask<UnityEngine.TrailRenderer>
	{
		[RequiredField]
		public BBParameter<float> StartSize;

		[RequiredField]
		public BBParameter<float> EndSize;

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
