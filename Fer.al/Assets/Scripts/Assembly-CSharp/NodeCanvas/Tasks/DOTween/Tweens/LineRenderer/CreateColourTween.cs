using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.LineRenderer
{
	[Category("DOTween/Tweens/LineRenderer")]
	[Name("Create Colour Tween", 0)]
	[Description("Creates a colour tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateColourTween : ActionTask<UnityEngine.LineRenderer>
	{
		[RequiredField]
		public BBParameter<Color> StartColour;

		[RequiredField]
		public BBParameter<Color> EndColour;

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
