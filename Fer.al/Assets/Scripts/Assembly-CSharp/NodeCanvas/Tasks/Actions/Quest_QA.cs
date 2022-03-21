using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest/Messages")]
	[Description("Server script - Add the quest to the players inventory on the server. Triggers a 'qa' (cmd = '80') on the server via a command in a networked objects states")]
	public class Quest_QA : NetworkActionTask
	{
		public string questName;

		public string questID;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
