using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category("DOTween/Tweens/Camera")]
	[Name("Create Camera Near Clip Plane Tween", 0)]
	[Description("Creates a camera near clip plane tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateNearPlaneClipTween : ActionTask<Camera>
	{
		public BBParameter<float> Duration;

		public BBParameter<float> To;

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
