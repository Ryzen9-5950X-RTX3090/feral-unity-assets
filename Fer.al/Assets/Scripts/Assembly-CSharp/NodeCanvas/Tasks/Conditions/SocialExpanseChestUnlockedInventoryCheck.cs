using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inventory")]
	[Description("Check the status of a social expanse chest unlock in a users inventory")]
	public class SocialExpanseChestUnlockedInventoryCheck : ConditionTask
	{
		public string socialExpanseLevelDefID;

		public string chestUUID;

		public Interactable.EItemType itemType;

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
