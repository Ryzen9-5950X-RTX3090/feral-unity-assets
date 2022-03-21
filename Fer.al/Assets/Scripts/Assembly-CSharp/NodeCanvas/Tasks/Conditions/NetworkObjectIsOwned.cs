using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Network")]
	[Description("Check if a networked object is owned / available to be picked up")]
	public class NetworkObjectIsOwned : NetworkConditionTask<NetworkedObjectInfo>
	{
		public Interactable.EItemType itemType;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
