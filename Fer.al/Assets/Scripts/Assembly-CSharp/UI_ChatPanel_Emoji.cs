using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class UI_ChatPanel_Emoji : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private EmojiGridLayoutGroup _gridLayout;

	[SerializeField]
	private Canvas _windowedCanvas;

	[SerializeField]
	private Canvas _expandedCanvas;

	private bool? _gridExceedsBounds;

	public void ToggleBtnClicked_Emoji(bool inIsOn)
	{
	}

	private void Start()
	{
	}

	private void RefreshCanvasChoice()
	{
	}
}
