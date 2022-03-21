using System.Net;
using System.Net.Sockets;

public class AltTcpListener : TcpListener
{
	public new bool Active
	{
		get
		{
			return default(bool);
		}
	}

	public AltTcpListener(IPEndPoint localEp)
	{
	}

	public AltTcpListener(IPAddress localaddr, int port)
	{
	}
}
