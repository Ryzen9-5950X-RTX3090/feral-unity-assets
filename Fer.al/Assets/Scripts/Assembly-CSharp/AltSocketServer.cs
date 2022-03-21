using System;
using System.Collections;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

public class AltSocketServer
{
	protected AltTcpListener Listener;

	protected readonly AltIClientSocketHandlerDelegate ClientSocketHandlerDelegate;

	protected readonly string SeparatorString;

	protected readonly Encoding Encoding;

	protected ArrayList ClientHandlerThreads;

	protected readonly int portNumber;

	protected readonly IPEndPoint localEndPoint;

	protected readonly int maxClients;

	public int PortNumber
	{
		get
		{
			return default(int);
		}
	}

	public IPEndPoint LocalEndPoint
	{
		get
		{
			return null;
		}
	}

	public int MaxClients
	{
		get
		{
			return default(int);
		}
	}

	public int ClientCount
	{
		get
		{
			return default(int);
		}
	}

	public bool IsServerStopped()
	{
		return default(bool);
	}

	public AltSocketServer(AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, int portNumber = 13000, int maxClients = 1, string separatorString = "\n", [Optional] Encoding encoding)
	{
	}

	public void StartListeningForConnections()
	{
	}

	protected void ListenForConnection()
	{
	}

	protected void AcceptCallback(IAsyncResult ar)
	{
	}

	public void StopListeningForConnections()
	{
	}

	public void Cleanup()
	{
	}

	public bool IsStarted()
	{
		return default(bool);
	}
}
