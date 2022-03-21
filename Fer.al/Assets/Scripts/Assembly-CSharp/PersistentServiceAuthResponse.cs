using LitJson;
using Server;

public abstract class PersistentServiceAuthResponse : ServiceMessage
{
	public bool Success;

	public PersistentServiceAuthResponse(JsonData jsonData)
	{
	}
}
