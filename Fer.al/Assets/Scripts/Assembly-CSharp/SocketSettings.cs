using System.Net.Sockets;

public struct SocketSettings
{
	public TcpClient socket;

	public string requestSeparator;

	public string requestEnding;

	public bool logFlag;

	public SocketSettings(TcpClient socket, string requestSeparator, string requestEnding, bool logFlag)
	{
	}
}
