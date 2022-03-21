using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category("DOTween/Tweens/Camera")]
	[Name("Create Camera Shake Rotation Tween (Float Strength)", 0)]
	[Description("Creates a camera shake rotation tween with float strength for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateShakeRotationFloatTween : ActionTask<Camera>
	{
		public BBParameter<float> Duration;

		public BBParameter<float> Strength;

		public BBParameter<int> vibrato;

		public BBParameter<float> randomness;

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
