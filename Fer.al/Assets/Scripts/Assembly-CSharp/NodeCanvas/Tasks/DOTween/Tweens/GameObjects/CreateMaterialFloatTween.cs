using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Material Float Tween", 0)]
	[Description("Creates a float tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateMaterialFloatTween : ActionTask<Renderer>
	{
		[RequiredField]
		public BBParameter<float> Value;

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
