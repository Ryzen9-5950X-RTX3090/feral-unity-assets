using System;

[Serializable]
public abstract class ServiceRequest
{
	public string cmd;

	public ServiceRequest(string cmd)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
