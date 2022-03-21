using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Inventory")]
	[Description("Server script - Updates Item In Inventory. Triggers achievement progress, and next group object spawning")]
	public class UpdateItemInInventory : NetworkActionTask
	{
		public enum EUpdateType
		{
			Unlock = 1,
			Increment,
			Decrement
		}

		public EUpdateType updateType;

		public Interactable.EItemType itemType;

		public string listName;

		public string listDefID;

		public string shopName;

		public string shopDefID;

		public string inspirationName;

		public string inspirationDefId;

		public NetworkedObjectInfo socialExpanseAcquiredLockpick;

		public NetworkedObjectInfo socialExpanseUnlockedChest;

		public NetworkedObjectInfo socialExpanseRockFlip;

		public NetworkedObjectInfo socialExpanseDigSpot;

		[BlackboardOnly]
		public BBParameter<bool> anyUnlocked;

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

		private void OnInventoryShopUnlock(ShopUnlockItemResponse inMessage)
		{
		}

		private void OnInventoryUpdated(InventoryListResponse inMessage)
		{
		}
	}
}
