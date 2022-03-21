using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NatSuite.Recorders;
using NatSuite.Recorders.Clocks;
using UnityEngine;

public class VideoRecorderManager : SingletonManagerBase<VideoRecorderManager>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SaveVideoAsync>d__83 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public bool isErrored;

		public VideoRecorderManager <>4__this;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <WriteVideoToFileAsync>d__84 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public VideoRecorderManager <>4__this;

		private <>c__DisplayClass84_0 <>8__1;

		private <>c__DisplayClass84_1 <>8__2;

		private string <path>5__2;

		private TaskAwaiter<string> <>u__1;

		private string <defaultFolder>5__3;

		private string <newPath>5__4;

		private TaskAwaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private ScreenShotHandler _screenShotHandler;

	[SerializeField]
	private FeralAudioInfo _shutterSfx;

	private const float _oneBillionFloat = 1E+09f;

	private const long _oneBillionLong = 1000000000L;

	private bool _wasSelfieWindowOpen;

	private bool _wasMutedInEditor;

	private bool _wasMotionBlurEnabled;

	private int _missingAudioFrameCounter;

	private int _allotedBufferSize;

	private VideoRecorderFailureStatus _videoRecorderFailureStatus;

	private MP4Recorder _recorder;

	private GameObject _shutterFx;

	private RealtimeClock _clock;

	private Action _stopRecordingCallback;

	private bool IsAudioReady
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsReady
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsAudioFailed
	{
		get
		{
			return default(bool);
		}
	}

	private AllCameraRecordingInput CameraInput
	{
		get
		{
			return null;
		}
	}

	private bool IsCleaningUp
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private string RecordingFailed
	{
		get
		{
			return null;
		}
	}

	private string VideoFailedToRecord
	{
		get
		{
			return null;
		}
	}

	private string ReduceScreenResolution
	{
		get
		{
			return null;
		}
	}

	private string MutedAudioInEditor
	{
		get
		{
			return null;
		}
	}

	private string TimesUp
	{
		get
		{
			return null;
		}
	}

	private string TimeLimitReached
	{
		get
		{
			return null;
		}
	}

	private string DeleteVideo
	{
		get
		{
			return null;
		}
	}

	private string AreYouSureDeleteVideo
	{
		get
		{
			return null;
		}
	}

	private string Delete
	{
		get
		{
			return null;
		}
	}

	private string GoBack
	{
		get
		{
			return null;
		}
	}

	public bool IsRecording
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

	public bool IsCancelled
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

	public string TotalRecordingTime
	{
		get
		{
			return null;
		}
	}

	public string RecordingTimeLimit
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void ToggleRecording()
	{
	}

	public void StartRecording(Action stopRecordingCallback)
	{
	}

	public void StopRecording()
	{
	}

	public void CancelRecording()
	{
	}

	public void SyncCursorTexture(Texture2D cursorTexture)
	{
	}

	public void SetUIVisibility(bool isVisible)
	{
	}

	public void TakeScreenshot(bool isHidingUI)
	{
	}

	[IteratorStateMachine(typeof(<RecordVideoCoroutine>d__69))]
	private IEnumerator RecordVideoCoroutine()
	{
		return null;
	}

	private void Initialize()
	{
	}

	private void Deinitialize()
	{
	}

	private void InitializeRecorder()
	{
	}

	private void InitializeAudio()
	{
	}

	private void CommitAudioFrame()
	{
	}

	private void SetUIElementsVisibleFromSelfieWindow(bool isVisible)
	{
	}

	[IteratorStateMachine(typeof(<WaitForAudioEngineInitialization>d__76))]
	private IEnumerator WaitForAudioEngineInitialization()
	{
		return null;
	}

	private bool IsTimeLimitExceeded()
	{
		return default(bool);
	}

	private bool HandleErrors()
	{
		return default(bool);
	}

	private VideoRecorderFailureStatus GetVideoRecorderFailureStatus()
	{
		return default(VideoRecorderFailureStatus);
	}

	public void OnSelfieTaken(Texture2D screenshot)
	{
	}

	private Vector2Int GetVideoResolution()
	{
		return default(Vector2Int);
	}

	private void Cleanup()
	{
	}

	[AsyncStateMachine(typeof(<SaveVideoAsync>d__83))]
	private void SaveVideoAsync(bool isErrored)
	{
	}

	[AsyncStateMachine(typeof(<WriteVideoToFileAsync>d__84))]
	private Task WriteVideoToFileAsync()
	{
		return null;
	}

	private string GetDefaultVideoFolder()
	{
		return null;
	}

	private string GetDefaultVideoName(string folderPath)
	{
		return null;
	}

	private void LogRecordingErrorWithAnalytics(string errorMessage)
	{
	}
}
