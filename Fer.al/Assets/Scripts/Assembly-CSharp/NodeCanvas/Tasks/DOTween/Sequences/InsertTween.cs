using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Insert Tween", 0)]
	[Description("Insert a tween at a given time position in a sequence")]
	[Icon("DOTweenTween", false, "")]
	public class InsertTween : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Sequence> Sequence;

		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

		[RequiredField]
		public BBParameter<float> TimePosition;

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
