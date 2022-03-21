using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Kill Tweens", 0)]
	[Description("Kills all tweens related to the object")]
	[Icon("DOTweenTween", false, "")]
	public class KillTweens : ActionTask
	{
		public BBParameter<bool> ShouldComplete;

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
