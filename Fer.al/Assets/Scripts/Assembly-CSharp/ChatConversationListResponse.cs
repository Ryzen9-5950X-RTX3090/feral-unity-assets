using LitJson;
using Server;
using Services.Chat;

[RoutedMessage("users.conversations", QueueMessageMode.Never)]
public class ChatConversationListResponse : ServiceMessage
{
	public readonly ChatConversationData[] Conversations;

	public readonly string NextCursor;

	public ChatConversationListResponse(JsonData jsonData)
	{
	}
}
