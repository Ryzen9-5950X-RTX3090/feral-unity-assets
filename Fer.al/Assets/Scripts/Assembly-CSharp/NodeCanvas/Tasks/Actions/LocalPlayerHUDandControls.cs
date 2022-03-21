using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Player")]
	[Description("Enable or disable both the HUD and players control")]
	public class LocalPlayerHUDandControls : ActionTask
	{
		public BBParameter<bool> enableBoth;

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
