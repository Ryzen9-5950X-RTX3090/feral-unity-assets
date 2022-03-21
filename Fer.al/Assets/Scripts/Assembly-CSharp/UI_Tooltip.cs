using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Tooltip : ManagedBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	private const float HOVER_TIME = 0.5f;

	[SerializeField]
	private UI_TooltipController.Side _side;

	[SerializeField]
	[RootSelector("Text", "LocalizationChartData", false, false)]
	private string _localizationDefId;

	private string _text;

	private string _default;

	private string _overrideText;

	[SerializeField]
	private int _additionalOffset;

	[SerializeField]
	[Header("References")]
	private RectTransform _target;

	[SerializeField]
	private Graphic _graphic;

	[SerializeField]
	[Tooltip("Assign this to allow long-pres to show on mobile")]
	private FeralButton _longPressButton;

	private bool _isMobile;

	private bool _hovered;

	private float _hoverTimer;

	private bool _isShowing;

	public UI_TooltipController.Side Side
	{
		get
		{
			return default(UI_TooltipController.Side);
		}
	}

	public string Text
	{
		get
		{
			return null;
		}
	}

	public int AdditionalOffset
	{
		get
		{
			return default(int);
		}
	}

	public RectTransform Target
	{
		get
		{
			return null;
		}
	}

	public Graphic Graphic
	{
		get
		{
			return null;
		}
	}

	protected virtual void Reset()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	public void SetOverridingText(string inText)
	{
	}

	public override void MUpdate()
	{
	}

	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	public void SetLocalizationDefId(string inDefId)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
