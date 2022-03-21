using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Set Sequence Easing", 0)]
	[Description("Sets the easing type of the given sequence")]
	[Icon("DOTweenTween", false, "")]
	public class SetSequenceEasing : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Sequence> Sequence;

		[RequiredField]
		public BBParameter<float> EaseAmplitudeOrOvershoot;

		[RequiredField]
		public BBParameter<float> EasePeriod;

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
