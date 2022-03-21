using System.Collections;

public class ItemRef : SoftRef<Item>, IEqualityComparer
{
	public readonly string ItemId;

	public readonly ItemType ItemType;

	public ItemRef(string itemId, ItemType itemType)
	{
	}

	public new bool Equals(object x, object y)
	{
		return default(bool);
	}

	public int GetHashCode(object obj)
	{
		return default(int);
	}

	protected override void UpdateRef()
	{
	}

	public static implicit operator Item(ItemRef i)
	{
		return null;
	}

	public static implicit operator ItemRef(Item r)
	{
		return null;
	}
}
