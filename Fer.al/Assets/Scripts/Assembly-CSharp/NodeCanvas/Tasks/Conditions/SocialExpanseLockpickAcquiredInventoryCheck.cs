using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inventory")]
	[Description("Check the status of a social expanse lockpick acquisition in a users inventory")]
	public class SocialExpanseLockpickAcquiredInventoryCheck : ConditionTask
	{
		public NetworkedObjectInfo lockPick;

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
