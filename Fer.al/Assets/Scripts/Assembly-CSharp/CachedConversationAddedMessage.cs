using Services.Chat;

public class CachedConversationAddedMessage : Message
{
	public readonly ChatConversationData Conversation;

	public CachedConversationAddedMessage(ChatConversationData inConversation)
	{
	}
}
