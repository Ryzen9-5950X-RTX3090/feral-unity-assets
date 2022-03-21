using Services.Chat;

public class RoomConversationMessage : Message, ITaggedMessage
{
	public readonly ChatEntry ChatEntry;

	public string GetTag()
	{
		return null;
	}

	public RoomConversationMessage(ChatEntry inChatEntry)
	{
	}
}
