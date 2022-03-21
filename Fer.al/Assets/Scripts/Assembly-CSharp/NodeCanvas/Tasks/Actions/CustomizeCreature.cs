using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Tutorial")]
	[Description("Open customization window and wait for it to be closed")]
	public class CustomizeCreature : NetworkActionTask
	{
		protected override void OnExecute()
		{
		}

		private void OnWindowClosed(WindowClosedMessage inMessage)
		{
		}
	}
}
