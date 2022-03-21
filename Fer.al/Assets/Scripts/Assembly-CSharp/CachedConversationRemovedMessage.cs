using Services.Chat;

public class CachedConversationRemovedMessage : Message
{
	public readonly ChatConversationData Conversation;

	public CachedConversationRemovedMessage(ChatConversationData inConversation)
	{
	}
}
