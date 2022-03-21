using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class UI_LoadingBlocker : MonoBehaviour
{
	public CanvasGroup mainCanvasGroup;

	public UnityEvent OnShowEvent;

	public UnityEvent OnHideEvent;

	public UnityEvent OnShowCompleteEvent;

	public UnityEvent OnHideCompleteEvent;

	[SerializeField]
	private RectTransform _loadingSpiral;

	[SerializeField]
	private Camera _uiCamera;

	public static UI_LoadingBlocker instance
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

	public bool IsFading
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

	public bool IsVisible
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

	public bool IsVisibleOrFading
	{
		get
		{
			return default(bool);
		}
	}

	public void Start()
	{
	}

	private void Update()
	{
	}

	public void Show([Optional] Vector2 inViewportPosition)
	{
	}

	public void Hide()
	{
	}

	public void HideAndDestroy()
	{
	}

	private void ResetToHidden()
	{
	}

	private void OnDestroy()
	{
	}
}
