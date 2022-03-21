using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category("DOTween/Tweens/Camera")]
	[Name("Create Camera Far Clip Plane Tween", 0)]
	[Description("Creates a camera far clip plane tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateFarPlaneClipTween : ActionTask<Camera>
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
