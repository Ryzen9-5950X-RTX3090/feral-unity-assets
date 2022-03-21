using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inventory")]
	[Description("Check the status of an inspiration in a user's inventory")]
	public class InspirationInventoryCheck : ConditionTask
	{
		public string inspirationDefName;

		public string inspirationDefId;

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
