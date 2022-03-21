using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Recipe")]
	[Description("Does the player own the recipe?")]
	public class CheckOwnedRecipe : ConditionTask
	{
		public BBParameter<string> recipeDefId;

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
