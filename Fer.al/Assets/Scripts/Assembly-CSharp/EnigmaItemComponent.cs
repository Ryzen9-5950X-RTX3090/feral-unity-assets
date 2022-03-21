using System;

[Serializable]
public class EnigmaItemComponent : ItemComponent
{
	private EnigmaDefComponent _enigmaDefComponent;

	public bool activated;

	public EnigmaDefComponent EnigmaDefComponent
	{
		get
		{
			return null;
		}
	}

	public void unlock()
	{
	}

	protected override ItemComponent UpdateFromServerOverride(ItemComponent fromServer)
	{
		return null;
	}
}
