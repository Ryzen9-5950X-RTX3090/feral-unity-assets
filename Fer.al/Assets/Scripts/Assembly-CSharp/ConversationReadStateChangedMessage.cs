public class ConversationReadStateChangedMessage : Message
{
	public readonly string ConversationId;

	public readonly bool IsRead;

	public readonly int UnreadCount;

	public ConversationReadStateChangedMessage(string inConversationId, bool inIsRead, int inUnreadCount)
	{
	}
}
