public class SanctuaryRemoveMessage : Message
{
	public readonly string itemId;

	public readonly int roomId;

	public readonly SanctuaryItemCategory category;

	public SanctuaryRemoveMessage(string inItemId, int inRoomId, SanctuaryItemCategory inCategory)
	{
	}
}
