using TMPro;
using UnityEngine;

public class UI_MaxDecalsWarning : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private CanvasGroup _tabWarningCanvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _text;

	[SerializeField]
	private Color _redColor;

	private UI_Window_CreatureCustomization _window;

	private string _baseWarningText;

	private bool _isShowing;

	private void Start()
	{
	}

	private void Setup()
	{
	}

	private void OnDecalCountChanged(int inDecalCount)
	{
	}
}
