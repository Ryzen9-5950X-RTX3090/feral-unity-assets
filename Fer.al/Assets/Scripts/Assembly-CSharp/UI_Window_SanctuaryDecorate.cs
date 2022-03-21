using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_SanctuaryDecorate : UI_Window
{
	[SerializeField]
	[Header("Content Panels")]
	private CanvasGroup _furnitureListPanel;

	[SerializeField]
	private CanvasGroup _lightSettingsPanel;

	[SerializeField]
	private CanvasGroup _favoriteLooksPanel;

	[SerializeField]
	private RectTransform _sidePanel;

	[SerializeField]
	private RectTransform _controlPanel;

	[SerializeField]
	private WWTextMeshProUGUI _currentModeText;

	[SerializeField]
	private FeralButton _goToInteriorBtn;

	[SerializeField]
	private FeralButton _goToExteriorBtn;

	[SerializeField]
	private WWTextMeshProUGUI _categoryText;

	[SerializeField]
	private UI_LazyItemList_SanctuaryDecoration _itemList;

	[SerializeField]
	private UI_TabGroup _filterTabGroup;

	[SerializeField]
	private FeralButton _dayNightToggle;

	[SerializeField]
	private FeralButton _cameraResetBtn;

	[SerializeField]
	private WWImage _shardImage;

	[SerializeField]
	[Header("Interior Controls")]
	private GameObject _floorNavigationGroup;

	[SerializeField]
	private WWTextMeshProUGUI _floorNameText;

	[SerializeField]
	private FeralButton _floorUpBtn;

	[SerializeField]
	private FeralButton _floorDownBtn;

	[SerializeField]
	private GameObject _roomNavigationGroup;

	[SerializeField]
	private FeralButton _roomLeftBtn;

	[SerializeField]
	private FeralButton _roomUpBtn;

	[SerializeField]
	private FeralButton _roomRightBtn;

	[SerializeField]
	private FeralButton _roomDownBtn;

	[SerializeField]
	private TMP_InputField _roomName;

	private bool _sidePanelIsOn;

	private string[] _filterStrings;

	[RuntimeInitializeOnLoadMethod]
	private static void StaticInit()
	{
	}

	private static void OnSanctuaryExited(SanctuaryExitMessage inMessage)
	{
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

	public override void MOnDestroy()
	{
	}

	private void OnFilterChanged(int inFilterIndex)
	{
	}

	public void BtnClicked_RotateCamera()
	{
	}

	public void BtnClicked_ZoomIn()
	{
	}

	public void BtnClicked_ZoomOut()
	{
	}

	public void BtnClicked_GoToInterior()
	{
	}

	public void BtnClicked_GoToExterior()
	{
	}

	public void BtnClicked_Shop()
	{
	}

	public void BtnClicked_ToggleDayNight(bool inIsOn)
	{
	}

	public void BtnClicked_ToggleSidePanel()
	{
	}

	public void BtnClicked_RemoveAllDecorations()
	{
	}

	public void BtnClicked_FloorUp()
	{
	}

	public void BtnClicked_FloorDown()
	{
	}

	public void BtnClicked_RoomLeft()
	{
	}

	public void BtnClicked_RoomUp()
	{
	}

	public void BtnClicked_RoomRight()
	{
	}

	public void BtnClicked_RoomDown()
	{
	}

	public void BtnClicked_SaveLook()
	{
	}

	public void OnEndEdit_RoomName()
	{
	}

	private void SetInteriorMode(bool inIsInterior)
	{
	}

	private void RefreshRoomName()
	{
	}

	private void RefreshFloorNavigation()
	{
	}

	private void RefreshRoomNavigation()
	{
	}

	private bool CheckRoomNavigation(int inDirection)
	{
		return default(bool);
	}

	private void DoRoomNavigation(int inDirection)
	{
	}

	private void OnSanctuaryObjectDragStart(SanctuaryObjectDragStartMessage inMessage)
	{
	}

	private void OnSanctuaryObjectDragEnd(SanctuaryObjectDragEndMessage inMessage)
	{
	}

	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage)
	{
	}

	private void OnSanctuaryCameraRotate(SanctuaryCameraRotateMessage inMessage)
	{
	}

	private void SlideSidePanel()
	{
	}
}
