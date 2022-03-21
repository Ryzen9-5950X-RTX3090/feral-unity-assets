using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
	[SerializeField]
	private string _cutsceneName;

	[SerializeField]
	private string _mainAnimationName;

	[SerializeField]
	private string _startTriggerName;

	[SerializeField]
	private string _endTriggerName;

	[SerializeField]
	private string _idleAnimationName;

	[SerializeField]
	private bool _hasAnimationFile;

	[SerializeField]
	private bool _hasSaveFile;

	[SerializeField]
	private bool _isSkippable;

	[SerializeField]
	private bool _delayLevelNameDisplay;

	[SerializeField]
	private bool _autoPlayOnLevelLoad;

	[SerializeField]
	private bool _playOnce;

	[SerializeField]
	private bool _alwaysForcePlayForDebugging;

	[SerializeField]
	private bool _isUsingFinalShot;

	[SerializeField]
	private Vector3 _finalShotPosition;

	[SerializeField]
	private Vector3 _finalShotRotation;

	[SerializeField]
	[Range(0f, 10f)]
	private float _finalShotReturnInterpolationTime;

	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private Canvas _skipCanvas;

	[SerializeField]
	[Range(0f, 100f)]
	private float _cameraStartInterpolationAnimationOffset;

	[SerializeField]
	[Range(0f, 10f)]
	private float _skipCanvasDelaySeconds;

	[SerializeField]
	[Range(0.01f, 3f)]
	private float _skipCanvasFadeUpSeconds;

	[SerializeField]
	[Range(0f, 100f)]
	private int _frameRateRollingAverageCount;

	private readonly IDictionary<Camera, float> _originalFieldsOfViewLookup;

	private readonly List<float> _mostRecentDeltaTimes;

	private float? _lastTimeSinceStartup;

	private Action<CutscenePlaybackState> _cutsceneEndedCallback;

	private bool _wasOriginalFieldsOfViewCaptured;

	private bool _isSkipRequested;

	private bool _isCancelRequested;

	private bool _isTestPlay;

	protected string SaveFilePrefix
	{
		get
		{
			return null;
		}
	}

	protected Camera Camera
	{
		get
		{
			return null;
		}
	}

	protected Animator Animator
	{
		get
		{
			return null;
		}
	}

	protected Avatar_Local Player
	{
		get
		{
			return null;
		}
	}

	protected Avatar_AutoMovement AvatarAutoMovement
	{
		get
		{
			return null;
		}
	}

	protected string MainAnimationName
	{
		get
		{
			return null;
		}
	}

	protected string StartTriggerName
	{
		get
		{
			return null;
		}
	}

	protected string EndTriggerName
	{
		get
		{
			return null;
		}
	}

	protected string IdleAnimationName
	{
		get
		{
			return null;
		}
	}

	protected bool IsSkippable
	{
		get
		{
			return default(bool);
		}
	}

	protected bool DelayLevelNameDisplay
	{
		get
		{
			return default(bool);
		}
	}

	protected bool IsFinishCutsceneRequested
	{
		get
		{
			return default(bool);
		}
	}

	protected Vector3 OriginalMainCameraPosition
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected Quaternion OriginalMainCameraRotation
	{
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected float OriginalMainCameraFieldOfView
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string CutsceneName
	{
		get
		{
			return null;
		}
	}

	public string ApplicableSceneName
	{
		get
		{
			return null;
		}
	}

	public bool AutoPlayOnLevelLoad
	{
		get
		{
			return default(bool);
		}
	}

	public virtual bool IsPlayable
	{
		get
		{
			return default(bool);
		}
	}

	public CutscenePlaybackState PlaybackState
	{
		[CompilerGenerated]
		get
		{
			return default(CutscenePlaybackState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsInitialized
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

	public int PlayCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float NormalizedPlaybackTime
	{
		get
		{
			return default(float);
		}
	}

	public float TotalTime
	{
		get
		{
			return default(float);
		}
	}

	public void Initialize()
	{
	}

	public bool TryPlay(bool force = false, [Optional] Action<CutscenePlaybackState> cutsceneEndedCallback)
	{
		return default(bool);
	}

	public bool TrySkip(bool force = false)
	{
		return default(bool);
	}

	public virtual bool TrySetNormalizedPlaybackTime(float time)
	{
		return default(bool);
	}

	public bool TryCancel()
	{
		return default(bool);
	}

	protected virtual void PrePlay()
	{
	}

	[IteratorStateMachine(typeof(<Play>d__96))]
	protected virtual IEnumerator Play()
	{
		return null;
	}

	protected virtual void UpdateCutscene()
	{
	}

	protected virtual void PostPlay()
	{
	}

	[IteratorStateMachine(typeof(<InterpolateCameraToStartAnimationOffset>d__99))]
	protected IEnumerator InterpolateCameraToStartAnimationOffset()
	{
		return null;
	}

	protected void SetCaptureFrameRateFromRollingAverage()
	{
	}

	protected void EnableInput()
	{
	}

	protected void DisableInput()
	{
	}

	protected void ShowHUD()
	{
	}

	protected void HideHUD()
	{
	}

	protected void SetCursorEnabled(bool isEnabled)
	{
	}

	protected void EnableCursorIfSkippable()
	{
	}

	protected void EnableAnimation()
	{
	}

	protected void DisableAnimation()
	{
	}

	protected void EnableCutsceneAudio()
	{
	}

	protected void DisableCutsceneAudio()
	{
	}

	protected void RestoreMainCamera()
	{
	}

	protected void SetupCutsceneCamera()
	{
	}

	protected void RestoreNPCCulling()
	{
	}

	protected void OverrideNPCCulling()
	{
	}

	protected void SetFieldOfView(float fieldOfView)
	{
	}

	protected void SaveOriginalMainCameraProperties()
	{
	}

	protected void SaveOriginalFieldsOfView()
	{
	}

	protected void RestoreOriginalFieldsOfView()
	{
	}

	protected virtual void SaveLocalData()
	{
	}

	protected virtual void LoadLocalData()
	{
	}

	[IteratorStateMachine(typeof(<BeginPlay>d__121))]
	private IEnumerator BeginPlay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<FinalShot>d__122))]
	private IEnumerator FinalShot()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DisplaySkipCanvas>d__123))]
	private IEnumerator DisplaySkipCanvas()
	{
		return null;
	}

	private void CleanupPostPlay()
	{
	}

	private float GetTotalTime()
	{
		return default(float);
	}

	private void EnsureValidInspectorItems()
	{
	}
}
