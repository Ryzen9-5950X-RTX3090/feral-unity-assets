using Server;

[MessageRouteHandler]
public static class DirectGenericXtHandler
{
	internal static void RequestDirectGenericMessage(string inUserUUIDToMessage, string message)
	{
	}

	[MessageSender(XtCmd.DirectGenericMessage, false)]
	private static void SendRequestDirectGenericMessage(string inUserUUIDToMessage, string messageToSend)
	{
	}

	[MessageRoute(XtCmd.DirectGenericMessage, QueueMessageMode.Never)]
	private static void HandleDirectGenericMessage(ReceivedDirectGenericMessageMessage message)
	{
	}
}
