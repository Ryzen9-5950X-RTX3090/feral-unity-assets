using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugButton_Link : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _buttonText;

		[SerializeField]
		private Button _button;

		private DebugButtonPanel _panel;

		private string _path;

		public void Setup(string inPath, DebugButtonPanel inPanel)
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
