using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Play Tween Backwards", 0)]
	[Description("Plays a given tween backwards")]
	[Icon("DOTweenTween", false, "")]
	public class PlayTweenBackwards : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

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

		private void OnTweenComplete()
		{
		}
	}
}
