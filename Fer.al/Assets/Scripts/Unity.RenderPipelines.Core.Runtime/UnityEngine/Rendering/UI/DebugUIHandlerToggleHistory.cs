using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
	{
		private Toggle[] historyToggles;

		private const float xDecal = 60f;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		protected internal override void UpdateValueLabel()
		{
		}

		[IteratorStateMachine(typeof(<RefreshAfterSanitization>d__4))]
		private IEnumerator RefreshAfterSanitization()
		{
			return null;
		}
	}
}
