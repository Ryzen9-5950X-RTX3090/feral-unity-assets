using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/DOTweenAnimator")]
	public class DOTweenAnimatorNode : ActionTask
	{
		public enum EDoTweenAnimatorAction
		{
			PlayForward,
			PlayBackward
		}

		public EDoTweenAnimatorAction tweenAction;

		public BBParameter<DOTweenAnimator> _tweenAnimator;

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
