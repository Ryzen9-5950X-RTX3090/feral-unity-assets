using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Material Vector Tween", 0)]
	[Description("Creates a vector tween for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateMaterialVectorTween : ActionTask<Renderer>
	{
		[RequiredField]
		public BBParameter<Vector3> Value;

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
