using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Pause Tween", 0)]
	[Description("Pauses a given tween")]
	[Icon("DOTweenTween", false, "")]
	public class PauseTween : ActionTask
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
