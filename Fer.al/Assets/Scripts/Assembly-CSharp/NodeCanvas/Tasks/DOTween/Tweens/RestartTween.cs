using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Restart Tween", 0)]
	[Description("Restarts a given tween")]
	[Icon("DOTweenTween", false, "")]
	public class RestartTween : ActionTask
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
