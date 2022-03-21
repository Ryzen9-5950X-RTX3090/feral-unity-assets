using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.Materials
{
	[Category("DOTween/Tweens/Materials")]
	[Name("Create Colour Property Tween", 0)]
	[Description("Creates a colour tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateColourPropertyTween : ActionTask
	{
		[RequiredField]
		public BBParameter<Material> Material;

		[RequiredField]
		public BBParameter<Color> NewColour;

		[RequiredField]
		public BBParameter<string> PropertyName;

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
