using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UniRx.Async;
using UnityEngine;
using WW.Debug;

public class RoomManager : SingletonManagerBase<RoomManager>
{
	private class AnalyticLevel
	{
		public enum EValue
		{
			WORLDMAP,
			NAVIGATION,
			LOGIN,
			MINIGAME
		}

		public string defName;

		public EValue value;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <ConfirmLeaveLevel>d__17 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<bool> <>t__builder;

		private <>c__DisplayClass17_0 <>8__1;

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
	private struct <DoDebugLogin>d__40 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private <>c__DisplayClass40_0 <>8__1;

		public RoomManager <>4__this;

		private TaskAwaiter<LoginMessage> <>u__1;

		private TaskAwaiter <>u__2;

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
	private struct <TeleportToLevel>d__47 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public RoomManager <>4__this;

		public LevelDefComponent.WorldMapInfo inWorldMapInfo;

		public bool inFromWorldMap;

		public string inDefID;

		public bool inCheckAlreadyInLevel;

		private UniTask.Awaiter <>u__1;

		private TaskAwaiter<bool> <>u__2;

		private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__3;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private bool _requestedRoomJoinFromServer;

	public ELevelType debugFakeServerLevelType;

	private bool _lastTeleportFromWorldMap;

	private int _roomJoinAttempts;

	public LevelDefComponent.WorldMapInfo worldMapInfo;

	private Coroutine _progressBarRoutine;

	private Coroutine _loadLevelRoutine;

	private RoomJoinMessage _joinSuccessMessage;

	private bool _ignoreNextRJ;

	private Coroutine _levelLoadServerTimeout;

	private AnalyticLevel _currentAnalyticLevel;

	public LevelDefComponent CurrentLevelDef
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

	public string CurrentLevelDefID
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public LevelDefComponent PreviousLevelDef
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

	public string PreviousLevelDefID
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool IsLevelFinishedLoading
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

	public bool IsWorld
	{
		get
		{
			return default(bool);
		}
	}

	public Transform FailRoomJoinSpawnPoint
	{
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static void LoadLevelSingle(string inLevelName)
	{
	}

	public static void LoadLevelAdditive(string inLevelName)
	{
	}

	[AsyncStateMachine(typeof(<ConfirmLeaveLevel>d__17))]
	public static Task<bool> ConfirmLeaveLevel()
	{
		return null;
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__36))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	public override void Deinit()
	{
	}

	public override void MStart()
	{
	}

	[AsyncStateMachine(typeof(<DoDebugLogin>d__40))]
	public void DoDebugLogin()
	{
	}

	[IteratorStateMachine(typeof(<WaitForLoadingScreen>d__41))]
	private IEnumerator WaitForLoadingScreen(Action onComplete)
	{
		return null;
	}

	private void OnRoomJoinSuccessResponse(RoomJoinSuccessMessage inMessage)
	{
	}

	private void OnRoomJoinSuccess(RoomJoinSuccessMessage message)
	{
	}

	private void OnRoomJoinFailedResponse(RoomJoinFailedMessage inMessage)
	{
	}

	private void Server_OnMinigameJoin(MinigameJoinMessage message)
	{
	}

	public void LoadPreviousLevel()
	{
	}

	[AsyncStateMachine(typeof(<TeleportToLevel>d__47))]
	public void TeleportToLevel(string inDefID, bool inFromWorldMap, bool inCheckAlreadyInLevel, LevelDefComponent.WorldMapInfo inWorldMapInfo)
	{
	}

	[DebugButton("LoadLevel", "RoomManager", false, false)]
	public Coroutine LoadLevel(string inLevelDefID)
	{
		return null;
	}

	private void ShowLoadingScreen()
	{
	}

	[IteratorStateMachine(typeof(<_LoadLevel>d__50))]
	private IEnumerator _LoadLevel(string inDefID)
	{
		return null;
	}

	private void RequestServerRoomJoin(LevelDefComponent inLevelDef, bool inIgnorePreload = false)
	{
	}

	public Coroutine AddLevel(string inLevelDefID)
	{
		return null;
	}

	public void RemoveLevel(string inLevelDefID)
	{
	}

	[IteratorStateMachine(typeof(<LoadLevelAdditiveRoutine>d__54))]
	private IEnumerator LoadLevelAdditiveRoutine(string inDefID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DownloadProgress>d__55))]
	private IEnumerator DownloadProgress(ManifestDef inManifestDef)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ActuallyLoadLevel>d__56))]
	public IEnumerator ActuallyLoadLevel(LevelDefComponent inLevelDef, [Optional] RoomJoinMessage roomJoinMessage)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadEmptyLevel>d__57))]
	public IEnumerator LoadEmptyLevel()
	{
		return null;
	}

	private void StartTimeoutForServerResponseOnLevelLoad()
	{
	}

	private void StopTimeoutForServerResponseOnLevelLoad()
	{
	}

	[IteratorStateMachine(typeof(<DoTimeoutServerResponseForLevelLoadCoroutine>d__61))]
	private IEnumerator DoTimeoutServerResponseForLevelLoadCoroutine()
	{
		return null;
	}

	private void OnLoadLevelTimeoutClosed()
	{
	}

	private static bool IsSceneAlreadyLoaded(string inName)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCurrentLevelFromFakeServer>d__64))]
	public static IEnumerator InitCurrentLevelFromFakeServer()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<InitCurrentLevel>d__65))]
	private IEnumerator InitCurrentLevel()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitForCurrentLevelThingsToFinish>d__66))]
	private IEnumerator WaitForCurrentLevelThingsToFinish()
	{
		return null;
	}

	private void ResetTouchableLayerMode()
	{
	}

	private void ResetPlayerCameraMode()
	{
	}

	private void SendCurrentAnalyticsLevel()
	{
	}

	private void SetCurrentAnalyticsLevel()
	{
	}
}
