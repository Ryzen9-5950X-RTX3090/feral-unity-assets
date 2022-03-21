using System.Runtime.CompilerServices;

public class InventoryItemRemovedEvent : Message, ITaggedMessage
{
	[CompilerGenerated]
	private readonly Item <Item>k__BackingField;

	[CompilerGenerated]
	private readonly int <Quantity>k__BackingField;

	public Item Item
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int Quantity
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	public bool IsFullyRemoved
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string GetTag()
	{
		return null;
	}

	public InventoryItemRemovedEvent(Item item, int quantity, bool inIsFullyRemoved)
	{
	}
}
