using LitJson;
using Server;

[RoutedMessage("conversations.create", QueueMessageMode.Never)]
public class ChatConversationCreateResponse : ServiceMessage
{
	public readonly string ConversationId;

	public readonly string ConversationType;

	public readonly string Error;

	public ChatConversationCreateResponse(JsonData jsonData)
	{
	}
}
