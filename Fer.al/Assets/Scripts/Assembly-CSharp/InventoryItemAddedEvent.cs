using System.Runtime.CompilerServices;

public class InventoryItemAddedEvent : Message
{
	public Item Item
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Quantity
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

	public InventoryItemAddedEvent(Item item, int quantity = 1)
	{
	}

	public static InventoryItemAddedEvent Create(Item item, int quantity = 1)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
