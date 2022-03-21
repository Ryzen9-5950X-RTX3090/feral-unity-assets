using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Reset : MonoBehaviour
{
	[SerializeField]
	private Canvas _canvas;

	private Camera _camera;

	public GameObject groupError;

	public GameObject groupButton;

	public Text labelMessage;

	public WWTextMeshProUGUI tmpLabelMessage;

	public Text labelButton;

	public WWTextMeshProUGUI tmpLabelButton;

	private SplashError _resetError;

	private ErrorCode _resetErrorCode;

	public static UI_Reset instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Canvas canvas
	{
		get
		{
			return null;
		}
	}

	public Camera Camera
	{
		get
		{
			return null;
		}
	}

	public static bool resetPopup
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private SystemLanguage GetLanguage
	{
		get
		{
			return default(SystemLanguage);
		}
	}

	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}

	public void Reset(SplashError inResetError, ErrorCode inErrorCode)
	{
	}

	[IteratorStateMachine(typeof(<ResetCamera>d__24))]
	private IEnumerator ResetCamera()
	{
		return null;
	}

	private void ResetCheck()
	{
	}

	private void ResetInCallback()
	{
	}

	private void Show()
	{
	}

	private void Hide()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void BtnClicked_Button()
	{
	}

	private bool ShowQuitButton(SplashError inSplashError)
	{
		return default(bool);
	}

	private void FeralErrors(SplashError inSplashError, ErrorCode errorCode, out string outError, out string outButton)
	{
	}

	private string Localization_ChartError()
	{
		return null;
	}

	private string Localization_SlowInternet()
	{
		return null;
	}

	private string Localization_BundleIncompatible()
	{
		return null;
	}

	private string Localization_Timeout()
	{
		return null;
	}

	private string Localization_NoCharts()
	{
		return null;
	}

	private string Localization_OutOfSpace()
	{
		return null;
	}

	private string Localization_UnencryptedCharts()
	{
		return null;
	}

	private string Localization_ErrorUpating()
	{
		return null;
	}

	private string Localization_WrongVersion()
	{
		return null;
	}

	private string Localization_ReloadAllCharts()
	{
		return null;
	}

	private string Localization_UnsupportedDevice()
	{
		return null;
	}

	private string Localization_CurrentUnityVersion()
	{
		return null;
	}

	private string Localization_Ok()
	{
		return null;
	}

	private string Localization_Retry()
	{
		return null;
	}

	private string Localization_Update()
	{
		return null;
	}

	private string Localization_NoInternet()
	{
		return null;
	}

	private string Localization_LostServerConnection()
	{
		return null;
	}

	private string GetLoc(string inDefId)
	{
		return null;
	}

	private bool ValidLoc(string inDefId)
	{
		return default(bool);
	}
}
