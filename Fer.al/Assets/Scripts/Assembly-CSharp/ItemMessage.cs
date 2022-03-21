using System.Runtime.CompilerServices;

public class ItemMessage : Message
{
	public Item item
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public ItemMessage(Item inItem)
	{
	}

	public override void ReturnToPool()
	{
	}
}
