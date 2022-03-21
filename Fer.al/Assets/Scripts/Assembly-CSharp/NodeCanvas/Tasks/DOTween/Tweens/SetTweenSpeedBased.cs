using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Set Tween Speed Based", 0)]
	[Description("If IsSpeedBased is True, sets the tween as speed based (the duration will represent the number of units/degrees the tween moves x second). \n\nNOTE: if you want your speed to be constant, also set the ease to Ease.Linear. \n\nHas no effect if the tween has already started or is inside a Sequence.")]
	[Icon("DOTweenTween", false, "")]
	public class SetTweenSpeedBased : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

		[RequiredField]
		public BBParameter<bool> IsSpeedBased;

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
