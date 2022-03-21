using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Tutorial")]
	[Description("Turn on or off a HUD element highlight")]
	public class OnboardingHighlightHudElement : NetworkActionTask
	{
		public OnboardingHighlightTargetId highlightTarget;

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
