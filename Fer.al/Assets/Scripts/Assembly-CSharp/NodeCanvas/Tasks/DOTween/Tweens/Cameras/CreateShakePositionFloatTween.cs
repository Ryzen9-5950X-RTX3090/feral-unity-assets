using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category("DOTween/Tweens/Camera")]
	[Name("Create Camera Shake Position Tween (Float Strength)", 0)]
	[Description("Creates a camera shake position tween with float strength for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateShakePositionFloatTween : ActionTask<Camera>
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
