using TMPro;
using UnityEngine;

public class UI_ChatPanel_Settings : MonoBehaviour
{
	private const string KEY_TEXTSIZE = "ChatSetting_TextSize";

	private const string KEY_OPACITY = "ChatSetting_Opacity";

	[SerializeField]
	private UI_Window_Chat _chatWindow;

	[SerializeField]
	private WWTextMeshProUGUI _textSizeText;

	[SerializeField]
	private WWTextMeshProUGUI _opacityText;

	private int? _textSize;

	private int? _opacity;

	private int TextSize
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	private int Opacity
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnTextSizeChanged()
	{
	}

	private void OnOpacityChanged()
	{
	}

	public void BtnClicked_TextSize_Increase()
	{
	}

	public void BtnClicked_TextSize_Decrease()
	{
	}

	public void BtnClicked_Opacity_Increase()
	{
	}

	public void BtnClicked_Opacity_Decrease()
	{
	}
}
