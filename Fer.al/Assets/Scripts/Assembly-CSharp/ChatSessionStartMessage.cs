using LitJson;
using Server;

[RoutedMessage("sessions.start", QueueMessageMode.Never)]
public class ChatSessionStartMessage : PersistentServiceAuthResponse
{
	public ChatSessionStartMessage(JsonData jsonData)
	{
	}
}
