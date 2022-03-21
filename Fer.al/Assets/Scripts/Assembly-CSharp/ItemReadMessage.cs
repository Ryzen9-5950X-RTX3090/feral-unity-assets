public class ItemReadMessage : ItemMessage
{
	private ItemReadMessage(Item inItem)
	{
	}

	public static ItemReadMessage Create(Item inItem)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
