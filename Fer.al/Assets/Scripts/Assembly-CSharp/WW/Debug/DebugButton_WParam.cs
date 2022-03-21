using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugButton_WParam : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _placeholderText;

		[SerializeField]
		private TMP_InputField _paramText;

		[SerializeField]
		private Toggle _paramToggle;

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
