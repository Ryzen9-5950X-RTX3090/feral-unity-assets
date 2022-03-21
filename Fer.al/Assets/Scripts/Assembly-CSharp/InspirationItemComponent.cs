using System;

[Serializable]
public class InspirationItemComponent : ItemComponent
{
	private InspirationDefComponent _inspirationDefComponent;

	public InspirationDefComponent InspirationDefComponent
	{
		get
		{
			return null;
		}
	}

	protected override ItemComponent UpdateFromServerOverride(ItemComponent fromServer)
	{
		return null;
	}
}
