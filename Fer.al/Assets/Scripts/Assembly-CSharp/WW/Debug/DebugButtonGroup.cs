using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugButtonGroup : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _headerText;

		[SerializeField]
		[Header("Button Type Groups")]
		private LayoutGroup _simpleButtonGroup;

		[SerializeField]
		private LayoutGroup _parameterButtonGroup;

		[SerializeField]
		private LayoutGroup _linkButtonGroup;

		[SerializeField]
		private LayoutGroup _fieldButtonGroup;

		[SerializeField]
		[Header("Prefab References")]
		private DebugButton_Simple _simpleButtonPrefab;

		[SerializeField]
		private DebugButton_WParam _parameterButtonPrefab;

		[SerializeField]
		private DebugButton_Link _linkButtonPrefab;

		[SerializeField]
		private DebugButton_Field _fieldButtonPrefab;

		public void Setup(DebugMethodGroup inGroup, DebugButtonPanel inPanel)
		{
		}
	}
}
