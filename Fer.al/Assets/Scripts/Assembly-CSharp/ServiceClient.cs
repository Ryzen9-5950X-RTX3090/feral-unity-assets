public class ServiceClient : WWTcpClient
{
	public ServiceClient(bool debug)
	{
	}

	~ServiceClient()
	{
	}

	public void SendAuth(string token, string uuid)
	{
	}

	public void Send(ServiceRequest req)
	{
	}

	protected override void WriteToSocket(string msg)
	{
	}

	protected override void HandleMessage(string msg)
	{
	}
}
