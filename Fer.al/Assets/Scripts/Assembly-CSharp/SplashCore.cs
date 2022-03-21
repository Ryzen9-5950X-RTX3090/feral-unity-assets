public class SplashCore : CoreBase<SplashCore>
{
	public MessageManager messageManager;

	public CoreLoadingManager loadingManager;

	public GlobalSettingsManager globalSettingsManager;

	public PlatformManager platformManager;

	public ChartDataManager chartDataManager;

	public CoreSplashManager splashManager;

	public override bool DestroyOnLoad
	{
		get
		{
			return default(bool);
		}
	}
}
