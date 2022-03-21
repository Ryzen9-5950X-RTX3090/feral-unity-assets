using LitJson;
using Server;
using Services.Chat;

[RoutedMessage("conversations.get", QueueMessageMode.Never)]
public class ChatConversationGetResponse : ServiceMessage
{
	public readonly ChatConversationData Conversation;

	public readonly string Error;

	public ChatConversationGetResponse(JsonData jsonData)
	{
	}
}
