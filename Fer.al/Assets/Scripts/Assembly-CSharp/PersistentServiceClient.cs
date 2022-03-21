public class PersistentServiceClient : WWTcpClient
{
	public PersistentServiceClient(bool debug, bool isSecured)
	{
	}

	~PersistentServiceClient()
	{
	}

	public void SendAuth(string token, string uuid)
	{
	}

	public void Send(PersistentServiceRequest req)
	{
	}

	protected override void WriteToSocket(string msg)
	{
	}

	protected override void HandleMessage(string msg)
	{
	}
}
