using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Insert Flag At Position", 0)]
	[Description("Inserts a callback in the sequence which will set a given flag to true when it occurs")]
	[Icon("DOTweenTween", false, "")]
	public class InsertFlagAtPosition : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Sequence> Sequence;

		[RequiredField]
		public BBParameter<bool> FlagVariable;

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
