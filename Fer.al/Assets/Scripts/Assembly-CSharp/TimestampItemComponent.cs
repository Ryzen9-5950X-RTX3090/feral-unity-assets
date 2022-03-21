using System;
using System.Runtime.CompilerServices;
using LitJson;

[Serializable]
public class TimestampItemComponent : ItemComponent
{
	[CompilerGenerated]
	private static readonly DateTime <Epoch>k__BackingField;

	public DateTime Timestamp
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private static DateTime Epoch
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	public override ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	protected override JsonData ToJsonOverride()
	{
		return null;
	}

	public TimestampItemComponent Setup(DateTime inDateTime)
	{
		return null;
	}
}
