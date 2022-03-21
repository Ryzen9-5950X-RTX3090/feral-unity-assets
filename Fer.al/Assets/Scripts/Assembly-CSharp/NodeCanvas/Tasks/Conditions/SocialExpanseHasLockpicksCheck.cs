using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inventory")]
	[Description("Check the count of lockpicks in a users inventory")]
	public class SocialExpanseHasLockpicksCheck : ConditionTask
	{
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
