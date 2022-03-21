using System.Runtime.CompilerServices;

public abstract class PurchaseableItemDef : InventoryItemDef
{
	public int cost
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void LoadEntry()
	{
	}
}
