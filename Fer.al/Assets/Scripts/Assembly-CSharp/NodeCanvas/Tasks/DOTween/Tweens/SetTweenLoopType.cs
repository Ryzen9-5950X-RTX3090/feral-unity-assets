using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Set Tween Loop Type", 0)]
	[Description("Sets the loop type of the given tween")]
	[Icon("DOTweenTween", false, "")]
	public class SetTweenLoopType : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

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
