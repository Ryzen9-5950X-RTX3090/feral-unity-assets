using LitJson;
using Server;
using Services.Chat;

[RoutedMessage("chat.postMessage", QueueMessageMode.Never)]
public class ChatConversationServiceMessage : ServiceMessage
{
	public readonly string ConversationId;

	public readonly ChatEntry ChatEntry;

	public readonly string Error;

	public ChatConversationServiceMessage(JsonData jsonData)
	{
	}
}
