using System;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public Toggle valueToggle;

		public Image checkmarkImage;

		public Func<int, bool> getter;

		public Action<int, bool> setter;

		internal int index;

		public void Init()
		{
		}

		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return default(bool);
		}

		public override void OnDeselection()
		{
		}

		public override void OnAction()
		{
		}

		internal void UpdateValueLabel()
		{
		}
	}
}
