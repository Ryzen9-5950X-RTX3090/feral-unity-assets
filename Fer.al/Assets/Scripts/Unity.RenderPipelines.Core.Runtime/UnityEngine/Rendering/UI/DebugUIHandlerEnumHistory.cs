using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField
	{
		private Text[] historyValues;

		private const float xDecal = 60f;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		protected override void UpdateValueLabel()
		{
		}

		[IteratorStateMachine(typeof(<RefreshAfterSanitization>d__4))]
		private IEnumerator RefreshAfterSanitization()
		{
			return null;
		}
	}
}
