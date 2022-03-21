public class SanctuaryAddMessage : Message
{
	public readonly string itemId;

	public readonly int roomId;

	public readonly SanctuaryItemCategory category;

	public SanctuaryAddMessage(string inItemId, int inRoomId, SanctuaryItemCategory inCategory)
	{
	}
}
