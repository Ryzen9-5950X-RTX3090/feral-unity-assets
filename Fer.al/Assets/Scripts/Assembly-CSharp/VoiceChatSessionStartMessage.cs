using LitJson;
using Server;

[RoutedMessage("session.start", QueueMessageMode.Never)]
public class VoiceChatSessionStartMessage : PersistentServiceAuthResponse
{
	public VoiceChatSessionStartMessage(JsonData jsonData)
	{
	}
}
