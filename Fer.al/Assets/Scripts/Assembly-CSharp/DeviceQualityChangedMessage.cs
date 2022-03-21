using System.Runtime.CompilerServices;

public class DeviceQualityChangedMessage : Message
{
	public DeviceQualityLevel QualityLevel
	{
		[CompilerGenerated]
		get
		{
			return default(DeviceQualityLevel);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DeviceQualityChangedMessage(DeviceQualityLevel inQualityLevel)
	{
	}
}
