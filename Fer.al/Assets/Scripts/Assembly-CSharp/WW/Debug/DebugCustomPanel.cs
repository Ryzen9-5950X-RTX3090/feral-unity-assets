using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugCustomPanel : MonoBehaviour
	{
		[SerializeField]
		private DebugConsoleWindow _console;

		[SerializeField]
		private LayoutGroup _contentParent;

		private bool _layoutRebuildNeeded;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnShown()
		{
		}

		private void OnHidden()
		{
		}

		[ContextMenu("RebuildLayout")]
		public void ReportFieldUpdated()
		{
		}
	}
}
