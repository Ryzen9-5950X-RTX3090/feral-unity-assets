using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Colour Tween", 0)]
	[Description("Creates a colour tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateColourTween : ActionTask<Renderer>
	{
		[RequiredField]
		public BBParameter<Color> NewColour;

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
