using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Server script - Contains startup command for a quest. Automatically called from server upon start. Place all actions in the state tree. which is needed so the exporter can construct the json file for the server.")]
	public class QuestStartup : NetworkActionTask
	{
		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
