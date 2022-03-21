using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Pause Sequence", 0)]
	[Description("Pauses a given Sequence")]
	[Icon("DOTweenTween", false, "")]
	public class PauseSequence : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Sequence> Sequence;

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
