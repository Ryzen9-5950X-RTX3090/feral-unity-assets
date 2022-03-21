using System;

[Serializable]
public class InfoItemComponent<T> : InfoItemComponent where T : BaseInfo
{
	public T info;

	public override BaseInfo Info
	{
		get
		{
			return null;
		}
	}
}
