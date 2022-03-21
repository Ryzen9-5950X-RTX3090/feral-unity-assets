namespace Iss.Handlers
{
	public interface IMessageHandler
	{
		void HandleMessage(object msgObj, IssClient.XtMsgType type);
	}
}
