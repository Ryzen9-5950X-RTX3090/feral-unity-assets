using System;

[Serializable]
public class QuantityItemComponent : SingleIntItemComponentBase
{
	public override string JsonKey
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
