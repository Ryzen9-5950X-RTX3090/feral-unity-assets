using System.Collections;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
	public class WWText : Text
	{
		public bool showUnlocalized;

		[RootSelector("Localization", "LocalizationChartData", false, true)]
		public string localizationDefID;

		[RootSelector("System Localization", "SystemLocalizationChartData", false, true)]
		public string systemLocalizationDefID;

		public bool useSystemLocalization;

		private bool _hasBeenLocalized;

		protected override void Awake()
		{
		}

		[IteratorStateMachine(typeof(<LocalizeOnLoad>d__6))]
		private IEnumerator LocalizeOnLoad()
		{
			return null;
		}
	}
}
