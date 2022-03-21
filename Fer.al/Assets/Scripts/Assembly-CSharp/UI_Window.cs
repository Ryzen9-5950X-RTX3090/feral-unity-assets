using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

[RequireComponent(typeof(Canvas))]
[ManagedBehaviourManager("WindowManager")]
public class UI_Window : UI_Panel
{
	public enum BackButtonBehavior
	{
		None,
		Close,
		Custom
	}

	public enum WindowState
	{
		Open,
		Opening,
		Closed,
		Closing
	}

	[SerializeField]
	protected Canvas _canvas;

	[SerializeField]
	protected GraphicRaycaster _raycaster;

	[SerializeField]
	protected bool _focusOnOpen;

	[SerializeField]
	[Tooltip("Set Open & Close ID to 0 if there are no animations")]
	protected string _openTweenID;

	[SerializeField]
	[Tooltip("Leave blank to use OpenTween Animation in reverse")]
	protected string _closeTweenID;

	[SerializeField]
	private bool _delayOpenAnimation;

	private bool _openAnimationIsDelaying;

	public UIWindowEvent OnOpenEvent;

	public UIWindowEvent OnOpenAnimationDelayCompleteEvent;

	public UIWindowEvent OnOpenCompleteEvent;

	public UIWindowEvent OnCloseEvent;

	public UIWindowEvent OnCloseCompleteEvent;

	[SerializeField]
	protected BackButtonBehavior _backButtonBehavior;

	[SerializeField]
	protected UIWindowEvent _onBackButtonEvent;

	private bool _assetsCleared;

	private WindowState _currentState;

	[SerializeField]
	protected bool _clearAssetsOnClose;

	[SerializeField]
	protected bool _destroyOnClose;

	[SerializeField]
	private CoreWindowManager.UILayer _uiLayer;

	private Tween _longestOpenTween;

	private Tween _longestCloseTween;

	private WW.Waiters.Waiter _openWaiter;

	private WW.Waiters.Waiter _closeWaiter;

	protected bool _useOpenAnimation;

	protected Canvas[] _subCanvases;

	public Canvas canvas
	{
		get
		{
			return null;
		}
	}

	public GraphicRaycaster Raycaster
	{
		get
		{
			return null;
		}
	}

	public string OpenTweenID
	{
		get
		{
			return null;
		}
	}

	public string CloseTweenID
	{
		get
		{
			return null;
		}
	}

	public bool DelayOpenAnimation
	{
		get
		{
			return default(bool);
		}
	}

	public bool OpenAnimationIsDelaying
	{
		get
		{
			return default(bool);
		}
	}

	public WindowState CurrentState
	{
		get
		{
			return default(WindowState);
		}
	}

	public bool IsOpenOrOpening
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsOpening
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsClosing
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsOpen
	{
		get
		{
			return default(bool);
		}
	}

	public bool CanOpen
	{
		get
		{
			return default(bool);
		}
	}

	public bool CanClose
	{
		get
		{
			return default(bool);
		}
	}

	public CoreWindowManager.UILayer UILayer
	{
		get
		{
			return default(CoreWindowManager.UILayer);
		}
	}

	public override void MAwake()
	{
	}

	public override void MOnDisable()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void Toggle(bool inAnimate = true)
	{
	}

	public void Open(bool force = false, bool inAnimate = true)
	{
	}

	public void Close(bool inForceClose = false, bool inAnimate = true)
	{
	}

	public void Close(bool inForceClose)
	{
	}

	public void CloseInstant(bool inForceClose)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	protected virtual void OnOpen()
	{
	}

	protected virtual void OnOpen(bool inAnimate)
	{
	}

	protected virtual void DoDelayedOpenAnimation()
	{
	}

	protected virtual void PlayOpenAnimation()
	{
	}

	protected virtual void OnOpenComplete()
	{
	}

	protected virtual void OnClose(bool inAnimate)
	{
	}

	protected virtual void PlayCloseAnimation()
	{
	}

	protected virtual void OnCloseComplete()
	{
	}

	protected virtual void OnShow()
	{
	}

	protected virtual void OnHide()
	{
	}

	private void OnTransformChildrenChanged()
	{
	}

	public override void MUpdate()
	{
	}

	protected void BackButtonPressed()
	{
	}

	protected virtual void OnBackButton()
	{
	}

	private void Reset()
	{
	}

	private void InitTweens()
	{
	}

	private void OnOpenAnimComplete()
	{
	}

	private void OnCloseAnimComplete()
	{
	}

	private void ClearAssets()
	{
	}
}
