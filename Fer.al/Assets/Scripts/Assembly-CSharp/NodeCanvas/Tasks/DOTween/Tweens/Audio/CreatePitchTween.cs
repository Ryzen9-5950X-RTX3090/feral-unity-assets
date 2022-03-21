using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Audio
{
	[Category("DOTween/Tweens/Audio")]
	[Name("Create Pitch Tween", 0)]
	[Description("Creates a pitch tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreatePitchTween : ActionTask<AudioSource>
	{
		[RequiredField]
		public BBParameter<float> Pitch;

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
