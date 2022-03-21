using LitJson;
using Server;

[RoutedMessage("conversations.addParticipant", QueueMessageMode.Never)]
public class ConversationAddResponse : ServiceMessage
{
	public readonly string ConversationId;

	public readonly string Participant;

	public readonly string Error;

	public ConversationAddResponse(JsonData jsonData)
	{
	}
}
