using UnityEngine;
using UnityEngine.UI;

public class UI_Window_SelfieMode : UI_Window
{
	[SerializeField]
	private FeralButton _showNamebarsButton;

	[SerializeField]
	private GameObject _viewfinderLandscape;

	[SerializeField]
	private GameObject _viewfinderPortrait;

	[SerializeField]
	private GameObject _helpPopup;

	[SerializeField]
	private GameObject _helpPopup_ForWindows;

	[SerializeField]
	private GameObject _helpPopup_ForMac;

	[SerializeField]
	private GameObject _groupStandalone;

	[SerializeField]
	private GameObject _recordVideoButton;

	[SerializeField]
	private AspectRatioFitter _viewFinderFitter;

	[SerializeField]
	private WWFeralSlider _fovSlider;

	[SerializeField]
	private Vector2 _fovMinMax;

	[SerializeField]
	private Transform _touchControlParent;

	private Transform _prevTouchControlParent;

	private bool _hasRequestedHideNamebars;

	private bool _isPortrait;

	private float _defaultFovSliderValue;

	private PlayerCameraMode _previousPlayerCameraMode;

	private bool _isFirstPersonView;

	public bool IsFirstPersonView
	{
		get
		{
			return default(bool);
		}
		private set
		{
		}
	}

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnInteracted(InteractablePointMessage inMessage)
	{
	}

	protected virtual void OnWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	public override void MUpdate()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_Help()
	{
	}

	public void BtnClicked_CloseHelp()
	{
	}

	public void ToggleBtnClicked_Namebars(bool inIsOn)
	{
	}

	public void BtnClicked_ResetCamera()
	{
	}

	public void BtnClicked_ToggleChat()
	{
	}

	public void BtnClicked_FocusChat()
	{
	}

	public void BtnClicked_Gallery()
	{
	}

	public void BtnClicked_FlipCamera()
	{
	}

	public void BtnClicked_TakePicture()
	{
	}

	public void BtnClicked_StartRecording()
	{
	}

	public void ToggleFirstPersonView()
	{
	}

	public void SliderValueChanged_Fov(float inValue)
	{
	}

	private string GetScreenShotFolderName()
	{
		return null;
	}
}
