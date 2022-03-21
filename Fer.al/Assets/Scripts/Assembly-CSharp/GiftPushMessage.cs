using Server;

public class GiftPushMessage : ServerMessage, ITaggedMessage
{
	public readonly string[] itemIds;

	public readonly int[] itemCounts;

	public readonly int numGifts;

	public string GetTag()
	{
		return null;
	}

	public GiftPushMessage(string inItemId)
	{
	}

	public GiftPushMessage(INetMessageReader data)
	{
	}
}
