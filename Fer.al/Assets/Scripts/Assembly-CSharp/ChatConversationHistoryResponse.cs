using System.Collections.Generic;
using LitJson;
using Server;
using Services.Chat;

[RoutedMessage("conversations.history", QueueMessageMode.Never)]
public class ChatConversationHistoryResponse : ServiceMessage
{
	public readonly List<ChatEntry> Messages;

	public readonly string nextCursor;

	public ChatConversationHistoryResponse(JsonData jsonData)
	{
	}
}
