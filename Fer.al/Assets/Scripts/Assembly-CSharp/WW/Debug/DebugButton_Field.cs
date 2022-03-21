using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugButton_Field : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _fieldName;

		[SerializeField]
		private Toggle _favoriteToggle;

		[SerializeField]
		private Toggle _valueToggle;

		[SerializeField]
		[Header("readonly objects")]
		private TextMeshProUGUI _readonlyFieldValueText;

		[SerializeField]
		[Header("read/write objects")]
		private TMP_InputField _fieldValueInput;

		[SerializeField]
		private TextMeshProUGUI _fieldValueHint;

		[SerializeField]
		private LayoutElement _inputTextAreaLayoutElement;

		[SerializeField]
		private GameObject _SetButton;

		private DebugButtonPanel _panel;

		private ConsoleFieldInfo _info;

		private bool _readonly;

		private bool _isBoolean;

		private string _fieldValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Setup(ConsoleFieldInfo inInfo, DebugButtonPanel inPanel)
		{
		}

		private void OnDestroy()
		{
		}

		public void BtnClicked_SetValue()
		{
		}

		public void BtnClicked_SetValue(string inValueText)
		{
		}

		public void ToggleChanged_Favorite()
		{
		}

		public void ToggleChanged_Value(bool inIsOn)
		{
		}

		private void OnSubmit(string inText)
		{
		}

		private void Update()
		{
		}

		private void UpdateFieldValue()
		{
		}
	}
}
