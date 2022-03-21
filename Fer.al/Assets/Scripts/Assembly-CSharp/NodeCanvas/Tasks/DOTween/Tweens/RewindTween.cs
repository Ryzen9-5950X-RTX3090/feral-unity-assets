using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Rewind Tween", 0)]
	[Description("Rewinds a given tween")]
	[Icon("DOTweenTween", false, "")]
	public class RewindTween : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

		public BBParameter<bool> IncludeDelay;

		public BBParameter<bool> WaitUntilFinished;

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
