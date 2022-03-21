using System.Collections;

public class PlatformManager : CorePlatformManager
{
	[SetInstance]
	public static PlatformManager instance;

	public override void Init()
	{
	}

	private void CoreLoaded()
	{
	}

	protected override void SetDeviceQualitySettingsMap()
	{
	}

	public override bool HasFinishCoroutine()
	{
		return default(bool);
	}

	public override IEnumerator FinishCoroutine()
	{
		return null;
	}
}
