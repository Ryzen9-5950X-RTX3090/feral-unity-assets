using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category("DOTween/Sequences")]
	[Name("Create Sequences", 0)]
	[Description("Creates a sequence for configuration or use")]
	[Icon("DOTweenTween", false, "")]
	public class CreateSequence : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<Sequence> CreatedSequence;

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
