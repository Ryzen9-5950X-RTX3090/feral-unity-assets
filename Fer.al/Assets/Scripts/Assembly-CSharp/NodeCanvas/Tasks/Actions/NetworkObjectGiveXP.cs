using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network")]
	[Description("Server script - Gives XP")]
	public class NetworkObjectGiveXP : NetworkActionTask<NetworkedObjectInfo>
	{
		public BBParameter<QuestManager.EGiveXpParamAction> action;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
