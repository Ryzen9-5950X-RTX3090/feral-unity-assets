using LitJson;
using Server;

[RoutedMessage("chat.auth", QueueMessageMode.Never)]
public class ChatAuthMessage : PersistentServiceAuthResponse
{
	public ChatAuthMessage(JsonData jsonData)
	{
	}
}
