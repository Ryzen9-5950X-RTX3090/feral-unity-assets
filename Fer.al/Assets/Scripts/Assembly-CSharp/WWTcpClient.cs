using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Threading;

public class WWTcpClient : IDisposable
{
	protected Hashtable messageHandlers;

	protected string host;

	protected int port;

	protected TcpClient socketConnection;

	private NetworkStream _networkStream;

	private SslStream _sslStream;

	private StreamWriter _streamWriter;

	protected const int READ_BUFFER_SIZE = 4096;

	protected byte[] byteBuffer;

	protected byte[] messageBuffer;

	protected int socketPollSleep;

	protected bool connected;

	protected bool connecting;

	protected Thread thrSocketReader;

	protected Thread thrConnect;

	protected Thread thrHttpPoll;

	protected Queue _queuedEvents;

	protected object _queuedEventsLocker;

	protected DateTime benchStartTime;

	protected int majVersion;

	protected int minVersion;

	protected int subVersion;

	protected bool isDisposed;

	private bool _isSecured;

	public WWTcpEvent.OnConnectionDelegate onConnection;

	public WWTcpEvent.OnConnectionLostDelegate onConnectionLost;

	public WWTcpEvent.OnMessageReceivedDelegate onMessageReceived;

	public WWTcpEvent.OnDebugMessageDelegate onDebugMessage;

	public bool runInQueueMode;

	public bool debugMode;

	protected object disconnectionLocker;

	protected Stream Stream
	{
		get
		{
			return null;
		}
	}

	public WWTcpClient()
	{
	}

	public WWTcpClient(bool debug, bool isSecured)
	{
	}

	~WWTcpClient()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Connect(string hostAdr, int port)
	{
	}

	private void ConnectThread()
	{
	}

	public virtual void Disconnect()
	{
	}

	public void ProcessEventQueue()
	{
	}

	public void ProcessSingleEventInEventQueue()
	{
	}

	public int NumEventsInEventQueue()
	{
		return default(int);
	}

	public void SetSocketPollDelay(int delay)
	{
	}

	internal void __Logout()
	{
	}

	protected void Initialize()
	{
	}

	protected virtual void Initialize(bool isLogOut)
	{
	}

	protected virtual void HandleMessage(string msg)
	{
	}

	protected virtual void SendString(string strMessage)
	{
	}

	protected virtual void SendString(string strMessage, bool log)
	{
	}

	protected virtual void HandleSocketConnection(object sender, EventArgs e)
	{
	}

	protected virtual void HandleSocketDisconnection()
	{
	}

	protected virtual void HandleIOError(string originalError)
	{
	}

	protected virtual void WriteToSocket(string msg)
	{
	}

	protected void HandleSocketData()
	{
	}

	protected void ClearMessageBuffer()
	{
	}

	protected ArrayList SplitBufferMessages()
	{
		return null;
	}

	protected void AddToMessageBuffer(byte[] buf, int count)
	{
	}

	protected void DispatchConnectionError(string errorMessage)
	{
	}

	internal void DispatchEvent(WWTcpEvent evt)
	{
	}

	internal void _EnqueueEvent(WWTcpEvent evt)
	{
	}

	protected virtual void _DispatchEvent(WWTcpEvent evt)
	{
	}

	internal void DebugMessage(string message)
	{
	}

	internal void ErrorTrace(string msg)
	{
	}
}
