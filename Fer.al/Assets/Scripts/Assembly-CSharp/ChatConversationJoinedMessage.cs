using LitJson;
using Server;
using Services.Chat;

[RoutedMessage("chat.convo.join", QueueMessageMode.Never)]
public class ChatConversationJoinedMessage : ServiceMessage, ITaggedMessage
{
	public enum ErrorValue
	{
		Unknown,
		NotFound,
		Privacy
	}

	public class ErrorInfo
	{
		public readonly ErrorValue Value;

		public readonly ConversationPrivacy Privacy;

		public ErrorInfo(ErrorValue v, ConversationPrivacy p)
		{
		}
	}

	public readonly ErrorInfo Error;

	public readonly ChatConversationData Conversation;

	public bool Success
	{
		get
		{
			return default(bool);
		}
	}

	public string GetTag()
	{
		return null;
	}

	public ChatConversationJoinedMessage(JsonData jsonData)
	{
	}
}
