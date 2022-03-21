using System;

[Serializable]
[ChartComponent("Item")]
public class ItemDefComponent : DefComponent, IItemDefComponent
{
	[ChartEnum]
	public ItemType itemType;

	protected override void LoadEntry()
	{
	}

	public static implicit operator bool(ItemDefComponent i)
	{
		return default(bool);
	}

	public void OnClientOnlyItemCreated(Item item)
	{
	}
}
