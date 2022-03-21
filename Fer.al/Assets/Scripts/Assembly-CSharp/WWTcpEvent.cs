using System.Collections;

public class WWTcpEvent
{
	public delegate void OnConnectionDelegate(bool success, string error);

	public delegate void OnConnectionLostDelegate();

	public delegate void OnMessageReceivedDelegate(string message);

	public delegate void OnDebugMessageDelegate(string message);

	internal const string onConnectionEvent = "OnConnection";

	internal const string onConnectionLostEvent = "OnConnectionLost";

	internal const string onMessageEvent = "OnMessage";

	internal const string onDebugMessageEvent = "OnDebugMessage";

	protected string type;

	protected Hashtable parameters;

	public WWTcpEvent(string type, Hashtable parameters)
	{
	}

	public new string GetType()
	{
		return null;
	}

	public object GetParameter(string key)
	{
		return null;
	}
}
