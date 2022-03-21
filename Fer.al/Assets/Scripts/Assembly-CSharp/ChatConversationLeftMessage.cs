using LitJson;
using Server;

[RoutedMessage("chat.convo.leave", QueueMessageMode.Never)]
public class ChatConversationLeftMessage : ServiceMessage, ITaggedMessage
{
	public readonly string ConversationId;

	public readonly string UserUUID;

	public string GetTag()
	{
		return null;
	}

	public ChatConversationLeftMessage(JsonData jsonData)
	{
	}
}
