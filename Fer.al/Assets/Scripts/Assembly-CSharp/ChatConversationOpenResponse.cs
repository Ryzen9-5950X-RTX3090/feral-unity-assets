using LitJson;
using Server;

[RoutedMessage("conversations.openPrivate", QueueMessageMode.Never)]
public class ChatConversationOpenResponse : ServiceMessage
{
	public readonly string ConversationId;

	public readonly string Error;

	public ChatConversationOpenResponse(JsonData jsonData)
	{
	}
}
