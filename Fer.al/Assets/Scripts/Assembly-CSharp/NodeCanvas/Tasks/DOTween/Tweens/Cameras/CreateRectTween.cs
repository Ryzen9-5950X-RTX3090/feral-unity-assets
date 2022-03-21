using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category("DOTween/Tweens/Camera")]
	[Name("Create Camera Rect Tween", 0)]
	[Description("Creates a camera rect tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateRectTween : ActionTask<Camera>
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
