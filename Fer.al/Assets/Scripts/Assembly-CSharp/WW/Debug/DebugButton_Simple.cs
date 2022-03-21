using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugButton_Simple : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _buttonText;

		[SerializeField]
		private Button _button;

		[SerializeField]
		private Toggle _favoriteToggle;

		private ConsoleMethodInfo _methodInfo;

		private DebugButtonPanel _panel;

		public void Setup(ConsoleMethodInfo inMethodInfo, DebugButtonPanel inPanel)
		{
		}

		private void OnButtonClicked()
		{
		}

		public void ToggleChanged_Favorite()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
