using System;

[Serializable]
public class PersistentServiceAuthRequest : PersistentServiceRequest
{
	public string token;

	public string uuid;

	public PersistentServiceAuthRequest(string token, string uuid)
	{
	}
}
