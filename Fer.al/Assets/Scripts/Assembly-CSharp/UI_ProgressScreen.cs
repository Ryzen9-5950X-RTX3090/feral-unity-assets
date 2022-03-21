using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_ProgressScreen : MonoBehaviour
{
	public enum UI_ProgressState
	{
		Spinner,
		ProgressBar
	}

	public GameObject groupBlocker;

	public CanvasGroup mainCanvasGroup;

	[Header("Progress Bar")]
	public GameObject progressBarGroup;

	public Slider progressBarSlider;

	public List<Text> labelListProgressBar;

	private float _toProgressBarValue;

	private float _lastToProgressBarValue;

	[Header("Spinner")]
	public CanvasGroup spinnerCanvasGroup;

	public List<Text> labelListSpinner;

	public UnityEvent OnShowEvent;

	public UnityEvent OnHideEvent;

	public UnityEvent OnShowCompleteEvent;

	public UnityEvent OnHideCompleteEvent;

	private Coroutine _internetConnectionTesterRoutine;

	private float _toProgressFailureTime;

	private float _toProgressFailureTimer;

	[SerializeField]
	[Header("Background")]
	private Sprite _loadingCityFera;

	[SerializeField]
	private Sprite _loadingExpanse;

	[SerializeField]
	private Sprite _loadingTradersPort;

	[SerializeField]
	private Sprite _loadingSanctuary;

	[SerializeField]
	private Image _backgroundImage;

	private Color _transparent;

	private Color _opaque;

	private UI_ProgressState _state;

	public static UI_ProgressScreen instance
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

	public UI_ProgressState State
	{
		get
		{
			return default(UI_ProgressState);
		}
		set
		{
		}
	}

	public void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateLevel()
	{
	}

	public void Show()
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

	public void SetProgressBar(float inProgress)
	{
	}

	public void ClearLabels()
	{
	}

	public void SetProgressLabelWithIndex(int inIndex, string inString)
	{
	}

	public void SetSpinnerLabelWithIndex(int inIndex, string inString)
	{
	}

	private void SetLabel(Text inLabel, string inString)
	{
	}

	private void OnDestroy()
	{
	}
}
