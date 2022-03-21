using Services.Chat;

public class RoomConversationChangedMessage : Message
{
	public readonly ChatConversationData Conversation;

	public RoomConversationChangedMessage(ChatConversationData inConversation)
	{
	}
}
