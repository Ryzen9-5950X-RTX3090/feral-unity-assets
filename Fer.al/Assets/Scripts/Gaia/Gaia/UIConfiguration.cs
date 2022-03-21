using UnityEngine;
using UnityEngine.UI;

namespace Gaia
{
	[ExecuteInEditMode]
	public class UIConfiguration : MonoBehaviour
	{
		[Header("UI Settings")]
		[Tooltip("Sets the UI text color")]
		public Color32 m_uiTextColor;

		[Tooltip("Button used to toggle the UI on and off")]
		public KeyCode m_uiToggleButton;

		private Text m_textContent;

		private Color32 storedColor;

		private bool storedUIStatus;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
