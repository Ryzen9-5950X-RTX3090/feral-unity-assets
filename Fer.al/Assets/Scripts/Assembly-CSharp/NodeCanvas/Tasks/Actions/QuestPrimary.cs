using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Adds the primary quest for the GUI objectives and triggers the start quest PostURI on the server")]
	public class QuestPrimary : NetworkActionTask
	{
		public string questName;

		public string questDefID;

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
