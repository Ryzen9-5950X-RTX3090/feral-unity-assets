using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Scene")]
	[Description("Loads a Cutscene")]
	public class LoadCutscene : ActionTask
	{
		public string levelDefId;

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
