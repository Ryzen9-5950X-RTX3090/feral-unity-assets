using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Server script - Update a quest summary tally")]
	public class QuestUpdateResults : NetworkActionTask
	{
		public enum EResultVariable
		{
			SideQuest,
			Cinders,
			Secrets,
			Treasures,
			Puzzles
		}

		public EResultVariable resultVariable;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
