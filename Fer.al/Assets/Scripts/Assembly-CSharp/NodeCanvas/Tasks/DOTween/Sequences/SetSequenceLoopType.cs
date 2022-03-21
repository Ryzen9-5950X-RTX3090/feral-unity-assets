using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Set Sequence Loop Type", 0)]
	[Description("Sets the loop type of the given sequence")]
	[Icon("DOTweenTween", false, "")]
	public class SetSequenceLoopType : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Sequence> Sequence;

		[RequiredField]
		public BBParameter<int> Loops;

		[RequiredField]
		public LoopType LoopType;

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
