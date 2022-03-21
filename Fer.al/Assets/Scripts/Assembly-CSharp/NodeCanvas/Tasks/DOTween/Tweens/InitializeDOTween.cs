using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Initialize DO Tween", 0)]
	[Description("Allows you to initialize DO Tween explicitly")]
	[Icon("DOTweenTween", false, "")]
	public class InitializeDOTween : ActionTask
	{
		public BBParameter<bool> RecycleAllByDefault;

		public BBParameter<bool> UseSafeMode;

		public LogBehaviour LogBehaviour;

		public BBParameter<int> ExpectedMaximumConcurrentTweens;

		public BBParameter<int> ExpectedMaximumConcurrentSequences;

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
