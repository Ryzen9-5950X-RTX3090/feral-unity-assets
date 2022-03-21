using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Toggle Sequence Pause", 0)]
	[Description("Toggles pause for a given Sequence")]
	[Icon("DOTweenTween", false, "")]
	public class ToggleSequencePause : ActionTask
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
