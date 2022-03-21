using System.Runtime.CompilerServices;

public class InventoryItemChangedEvent : Message, ITaggedMessage
{
	[CompilerGenerated]
	private readonly Item <Item>k__BackingField;

	[CompilerGenerated]
	private readonly Item <PreviousItemState>k__BackingField;

	public Item Item
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Item PreviousItemState
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string GetTag()
	{
		return null;
	}

	public InventoryItemChangedEvent(Item newItem, Item prevItem)
	{
	}
}
