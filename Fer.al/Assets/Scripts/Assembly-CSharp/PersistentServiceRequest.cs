using System;

[Serializable]
public abstract class PersistentServiceRequest
{
	public string cmd;

	public PersistentServiceRequest(string cmd)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
