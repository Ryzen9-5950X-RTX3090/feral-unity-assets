using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/CraftableItem")]
	[Description("How many craftable items")]
	public class CheckCraftableItemCount : ConditionTask
	{
		public BBParameter<string> craftableItemDefId;

		public CompareMethod checkType;

		public BBParameter<int> valueB;

		private int valueA
		{
			get
			{
				return default(int);
			}
		}

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
