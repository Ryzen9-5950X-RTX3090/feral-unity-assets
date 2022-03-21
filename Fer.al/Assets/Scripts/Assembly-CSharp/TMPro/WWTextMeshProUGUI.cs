using System.Collections;
using System.Runtime.CompilerServices;

namespace TMPro
{
	public class WWTextMeshProUGUI : TextMeshProUGUI
	{
		public bool showUnlocalized;

		[RootSelector("Localization", "LocalizationChartData", false, true)]
		public string localizationDefID;

		[RootSelector("System Localization", "SystemLocalizationChartData", false, true)]
		public string systemLocalizationDefID;

		public bool useSystemLocalization;

		private bool _hasBeenLocalized;

		public void ClearAssetReferences()
		{
		}

		protected override void Awake()
		{
		}

		[IteratorStateMachine(typeof(<LocalizeOnLoad>d__7))]
		private IEnumerator LocalizeOnLoad()
		{
			return null;
		}
	}
}
