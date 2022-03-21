using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Inventory")]
	[Description("Adds the quest to the clients quest log.")]
	public class QuestInventoryAdd : ActionTask
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

		protected override void OnExecute()
		{
		}
	}
}
