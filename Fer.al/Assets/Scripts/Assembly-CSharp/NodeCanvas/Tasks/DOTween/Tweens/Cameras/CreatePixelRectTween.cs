using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category("DOTween/Tweens/Camera")]
	[Name("Create Camera Pixel Rect Tween", 0)]
	[Description("Creates a camera pixel rect tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreatePixelRectTween : ActionTask<Camera>
	{
		public BBParameter<float> Duration;

		public BBParameter<Rect> To;

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
