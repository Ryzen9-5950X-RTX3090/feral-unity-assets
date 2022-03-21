using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/CraftableItem")]
	[Description("Give craftable item to the player.")]
	public class GiveCraftableItem : ActionTask
	{
		public BBParameter<string> craftableItemDefId;

		public BBParameter<int> amount;

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
