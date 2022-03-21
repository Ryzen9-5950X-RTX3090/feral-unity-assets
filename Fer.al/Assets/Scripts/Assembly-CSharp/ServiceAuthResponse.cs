using LitJson;
using Server;

public abstract class ServiceAuthResponse : ServiceMessage
{
	public bool Success;

	public ServiceAuthResponse(JsonData jsonData)
	{
	}
}
