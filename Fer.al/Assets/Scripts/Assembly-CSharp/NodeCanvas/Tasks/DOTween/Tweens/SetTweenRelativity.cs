using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Set Tween Delay", 0)]
	[Description("Sets the end point of a given tween to be relative (start + end) or absolute (end)")]
	[Icon("DOTweenTween", false, "")]
	public class SetTweenRelativity : ActionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<Tween> Tween;

		[RequiredField]
		public BBParameter<bool> IsRelative;

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
