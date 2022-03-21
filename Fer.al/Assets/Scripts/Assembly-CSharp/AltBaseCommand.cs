using System.IO;
using System.Net.Sockets;
using Assets.AltUnityTester.AltUnityDriver.UnityStruct;

public class AltBaseCommand
{
	private static int BUFFER_SIZE;

	protected SocketSettings SocketSettings;

	protected TcpClient Socket;

	public AltBaseCommand(SocketSettings socketSettings)
	{
	}

	public string Recvall()
	{
		return null;
	}

	protected void WriteInLogFile(string logMessage)
	{
	}

	public string CreateCommand(string[] arguments)
	{
		return null;
	}

	protected byte[] toBytes(string text)
	{
		return null;
	}

	protected string fromBytes(byte[] text)
	{
		return null;
	}

	protected string PositionToJson(AltUnityVector2 position)
	{
		return null;
	}

	protected string PositionToJson(float x, float y)
	{
		return null;
	}

	public static void HandleErrors(string data)
	{
	}

	public AltUnityTextureInformation ReceiveImage()
	{
		return default(AltUnityTextureInformation);
	}

	public static byte[] DeCompressScreenshot(byte[] screenshotCompressed)
	{
		return null;
	}

	public static T[] SubArray<T>(T[] data, int index, long length)
	{
		return null;
	}

	public static void CopyTo(Stream src, Stream dest)
	{
	}
}
