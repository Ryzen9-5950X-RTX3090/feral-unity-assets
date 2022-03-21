using System;

[Serializable]
public class ServiceAuthRequest : ServiceRequest
{
	public string token;

	public string uuid;

	public ServiceAuthRequest(string token, string uuid)
	{
	}
}
