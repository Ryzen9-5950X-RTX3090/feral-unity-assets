using Services.Chat;

public class ChatConversationMessage : Message
{
	public readonly string ConversationId;

	public readonly ChatEntry ChatEntry;

	public ChatConversationMessage(string inConversationId, ChatEntry inChatEntry)
	{
	}
}
