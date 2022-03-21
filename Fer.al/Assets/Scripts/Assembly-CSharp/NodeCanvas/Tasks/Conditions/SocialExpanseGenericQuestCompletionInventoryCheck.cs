using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inventory")]
	[Description("Check the status of a social expanse generic quest in a users inventory")]
	public class SocialExpanseGenericQuestCompletionInventoryCheck : ConditionTask
	{
		public string socialExpanseLinearGenericQuestDefID;

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
