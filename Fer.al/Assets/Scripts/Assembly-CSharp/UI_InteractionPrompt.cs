using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_InteractionPrompt : MonoBehaviour
{
	private enum EFillState
	{
		NONE,
		STARTED,
		FILLING
	}

	public enum EButtonState
	{
		NONE,
		BUTTON_DOWN,
		BUTTON_UP,
		UI_DOWN,
		UI_UP
	}

	private float _fillTimer;

	[SerializeField]
	private RectTransform _mainRectTransform;

	[SerializeField]
	private GameObject _panelObject;

	[SerializeField]
	private RectTransform _panelRectTransform;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWButton _button;

	[SerializeField]
	private Image _btnImage;

	[SerializeField]
	private Sprite _keyboardBtnSprite;

	[SerializeField]
	private Sprite _mobileBtnSprite;

	[SerializeField]
	private Transform _actionGroup;

	[SerializeField]
	private WWImage _actionIcon;

	[SerializeField]
	private UI_Tooltip _actionTooltip;

	[SerializeField]
	private Image _progressImage;

	[SerializeField]
	private UnityEvent _onProgressStart;

	[SerializeField]
	private UnityEvent _onProgressFinish;

	[SerializeField]
	private UnityEvent _onProgressCancel;

	[SerializeField]
	private GameObject _fxWheelRotate;

	[SerializeField]
	private GameObject _fxWheelFinish;

	private Vector3 _screenPosition;

	private bool _continuePressFromUI;

	private EFillState _fillState;

	private CustomController _customController;

	private Transform _targetTransform;

	private Vector3 _targetOffset;

	private Vector3 _targetOffsetFirstPerson;

	private Interactable _interactable;

	private EButtonState _desiredButtonState;

	private EButtonState _currentButtonState;

	public static UI_InteractionPrompt instance
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

	internal RectTransform mainRectTransform
	{
		get
		{
			return null;
		}
	}

	private void OnPrimaryInteractableUpdated(PrimaryInteractableUpdatedMessage inMessage)
	{
	}

	private void OnInteractableInteracted(InteractableInteractedMessage inMessage)
	{
	}

	private void Setup(Interactable inPromptTarget)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void StartFill()
	{
	}

	private void CancelFill()
	{
	}

	private void FinishFill()
	{
	}

	private void FinishFX()
	{
	}

	private void ResetButton()
	{
	}

	public void BtnClicked_InteractDown()
	{
	}

	public void BtnClicked_InteractUp()
	{
	}
}
