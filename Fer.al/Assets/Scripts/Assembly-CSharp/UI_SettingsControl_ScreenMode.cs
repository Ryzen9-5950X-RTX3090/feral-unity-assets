using TMPro;
using UnityEngine;

public class UI_SettingsControl_ScreenMode : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _screenModeText;

	private bool _isFullscreen;

	public bool IsFullscreen
	{
		get
		{
			return default(bool);
		}
		private set
		{
		}
	}

	private void Start()
	{
	}

	public void BtnClicked_ScreenModeNext()
	{
	}

	public void BtnClicked_ScreenModePrev()
	{
	}

	private void RefreshScreenModeText()
	{
	}
}
