using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class PersistentServiceConnection
{
	private PersistentServiceClient _client;

	private string _host;

	private int _port;

	private Coroutine _reconnectCoroutine;

	private int retrySeconds;

	public bool IsConnected
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsAuthorized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected void Init(string name, string host, int port, bool isDebug, bool isSecured)
	{
	}

	~PersistentServiceConnection()
	{
	}

	public void Connect()
	{
	}

	public void Login(string token, string uuid)
	{
	}

	public void Disconnect()
	{
	}

	public void ProcessEventQueue()
	{
	}

	public void Send(PersistentServiceRequest req)
	{
	}

	protected abstract void SendConnectMessage(bool succes, string error);

	protected abstract void SendConnectionLostMessage();

	protected abstract void ListenForAuthorizationMessage();

	protected void OnAuthMessage(PersistentServiceAuthResponse message)
	{
	}

	protected virtual void OnAuthorized()
	{
	}

	protected virtual void OnConnection(bool success, string error)
	{
	}

	private void OnConnectionLost()
	{
	}

	private void StartReconnectCoroutine()
	{
	}

	[IteratorStateMachine(typeof(<RetryConnect>d__32))]
	private IEnumerator RetryConnect()
	{
		return null;
	}

	private void OnMessageReceived(string message)
	{
	}

	private void OnDebugMessage(string message)
	{
	}

	protected void Log(string message)
	{
	}

	protected void LogError(string message)
	{
	}
}
