using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_SanctuaryExpansionRoomButton : MonoBehaviour
{
	public int roomIndex;

	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private WWTextMeshProUGUI _roomName;

	[SerializeField]
	private CanvasGroup _groupUnderConstruction;

	[SerializeField]
	[Header("Not Built")]
	private CanvasGroup _groupNotBuilt;

	[SerializeField]
	private WWImage _imageNotBuilt;

	[SerializeField]
	private Color _colorCanBeBuilt;

	[SerializeField]
	private Color _colorCannotBeBuilt;

	[SerializeField]
	[Header("Built")]
	private CanvasGroup _groupBuilt;

	[SerializeField]
	private UIEffect _roomOffEffect;

	[SerializeField]
	[Header("Expanded")]
	private CanvasGroup _groupExpanded;

	[SerializeField]
	private WWImage _imageExpansion;

	[SerializeField]
	private Color _colorExpansionOn;

	[SerializeField]
	private Color _colorExpansionOff;

	private UI_Window_Shop_SanctuaryExpansions _expansionShopUI;

	public string RoomName
	{
		get
		{
			return null;
		}
	}

	private UI_Window_Shop_SanctuaryExpansions ExpansionShopUI
	{
		get
		{
			return null;
		}
	}

	public bool IsTwiggleAvailable
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsRoomConnected
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsRoomOwned
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsExpansionOwned
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsRoomOn
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsExpansionOn
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateButtonState(bool isHighlighted)
	{
	}

	public void SetButtonSelected(bool inSelected)
	{
	}

	public void BtnClicked_OnRoomSelected()
	{
	}

	private void OnStateChanged(SanctuaryBuildStateChangedMessage inMessage)
	{
	}
}
