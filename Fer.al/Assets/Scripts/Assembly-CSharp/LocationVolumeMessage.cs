using System.Runtime.CompilerServices;

public class LocationVolumeMessage : Message
{
	public bool LocationEntered
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public LocationDefComponent LocationDef
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string LocationName
	{
		get
		{
			return null;
		}
	}

	public LocationVolumeMessage(string inLocationDefId, bool inEntered)
	{
	}
}
