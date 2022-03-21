using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inventory")]
	[Description("Check the status of a quest in a users inventory")]
	public class QuestInventoryCheck : ConditionTask
	{
		public enum EQuestStatus
		{
			Owned,
			Active,
			Complete
		}

		public EQuestStatus questStatus;

		public string questName;

		public string questID;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
