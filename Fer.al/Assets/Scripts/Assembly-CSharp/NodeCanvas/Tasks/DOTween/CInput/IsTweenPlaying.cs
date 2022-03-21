using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.CInput
{
	[Category("DOTween")]
	[Name("Is Tween Playing", 0)]
	[Description("Checks to see the if the tween is playing")]
	[Icon("DOTweenTween", false, "")]
	public class IsTweenPlaying : ConditionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
