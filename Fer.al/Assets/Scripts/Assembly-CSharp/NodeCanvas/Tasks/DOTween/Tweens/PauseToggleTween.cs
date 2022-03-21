using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Toggle Tween Pause", 0)]
	[Description("Toggles pause on a tween")]
	[Icon("DOTweenTween", false, "")]
	public class PauseToggleTween : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

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
