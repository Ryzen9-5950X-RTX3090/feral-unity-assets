using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Set Time Scale", 0)]
	[Description("Sets the global time scale for all tweens")]
	[Icon("DOTweenTween", false, "")]
	public class SetTweenTimeScale : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

		[RequiredField]
		public BBParameter<float> TimeScale;

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
