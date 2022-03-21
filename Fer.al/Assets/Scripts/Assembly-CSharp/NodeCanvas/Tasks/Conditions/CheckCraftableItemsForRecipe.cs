using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Recipe")]
	[Description("Does the player have all the craftableitems to create the recipe?")]
	public class CheckCraftableItemsForRecipe : ConditionTask
	{
		public BBParameter<string> recipeDefId;

		private bool _initialized;

		private int _craftableItemCount;

		private int[] _requiredCounts;

		private string[] _defIds;

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
