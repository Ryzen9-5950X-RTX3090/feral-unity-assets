public class ItemComponentRef<T> : SoftRef<T> where T : ItemComponent
{
	public readonly string ItemId;

	public ItemComponentRef(string itemId)
	{
	}

	protected override void UpdateRef()
	{
	}

	public static implicit operator T(ItemComponentRef<T> r)
	{
		return null;
	}

	public static implicit operator ItemComponentRef<T>(T i)
	{
		return null;
	}
}
