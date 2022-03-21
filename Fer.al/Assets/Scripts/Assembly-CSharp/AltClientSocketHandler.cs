using System.Net.Sockets;
using System.Text;

public class AltClientSocketHandler
{
	protected readonly TcpClient Client;

	protected readonly string SeparatorSequence;

	protected readonly char[] SeparatorSequenceChars;

	protected readonly Encoding Encoding;

	protected AltIClientSocketHandlerDelegate ClientSocketHandlerDelegate;

	public bool ToBeKilled;

	public AltClientSocketHandler(TcpClient client, AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, string separatorString, Encoding encoding)
	{
	}

	public void Cleanup()
	{
	}

	public void SendResponse(string response)
	{
	}

	public void SendResponse(byte[] response)
	{
	}

	public void Run()
	{
	}
}
