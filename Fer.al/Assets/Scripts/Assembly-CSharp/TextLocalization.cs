public class TextLocalization : MonoBehaviour
{
	[RootSelector("Localization", "LocalizationChartData", false, true)]
	public string localizationDefID;

	[RootSelector("System Localization", "SystemLocalizationChartData", false, true)]
	public string systemLocalizationDefID;
}
