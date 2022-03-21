using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category("DOTween/Tweens")]
	[Name("Set Time Scale", 0)]
	[Description("Sets the global time scale for all tweens")]
	[Icon("DOTweenTween", false, "")]
	public class SetGlobalTimeScale : ActionTask
	{
		[RequiredField]
		public BBParameter<float> TimeScale;

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
