using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Append Tween", 0)]
	[Description("Append a tween to a sequence")]
	[Icon("DOTweenTween", false, "")]
	public class AppendTween : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Sequence> Sequence;

		[RequiredField]
		public BBParameter<Tween> Tween;

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
