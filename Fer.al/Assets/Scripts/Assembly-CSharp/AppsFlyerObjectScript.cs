using AppsFlyerSDK;

public class AppsFlyerObjectScript : MonoBehaviour, IAppsFlyerConversionData
{
	public string devKey;

	public string appID;

	public bool isDebug;

	public bool getConversionData;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void onConversionDataSuccess(string conversionData)
	{
	}

	public void onConversionDataFail(string error)
	{
	}

	public void onAppOpenAttribution(string attributionData)
	{
	}

	public void onAppOpenAttributionFailure(string error)
	{
	}
}
