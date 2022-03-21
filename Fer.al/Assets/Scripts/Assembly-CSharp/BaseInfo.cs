using System;

[Serializable]
public class BaseInfo
{
	public virtual void ResetCaches()
	{
	}

	public T Clone<T>() where T : BaseInfo
	{
		return null;
	}

	public void CopyOver<T>(T inBaseInfo) where T : BaseInfo
	{
	}
}
