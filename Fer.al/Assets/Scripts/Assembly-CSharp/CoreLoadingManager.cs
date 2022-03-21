using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class CoreLoadingManager : CoreManagerBase<CoreLoadingManager>
{
	private static Action _onAnimCompleteCallback;

	private float _loadingTimer;

	private float _loadingTimeout;

	private static float _timeSpentLoading;

	private static string _timeSpentLoadingLevelName;

	private bool _isLoading;

	private bool _loadPending;

	private bool _queueMessages;

	private string _level;

	private List<string> _levelAdditives;

	public static bool ProgressScreenIsVisible
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsLoading
	{
		get
		{
			return default(bool);
		}
	}

	public static bool LoadPending
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool QueueMessages
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void Init()
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	public static void HideProgressScreen()
	{
	}

	public static void ShowProgressScreen([Optional] Action inOnAnimCompleteCallback)
	{
	}

	private void BackButtonOverride()
	{
	}

	private void OnLoadingUIOpened(Message inMessage)
	{
	}

	private void OnLoadingUIClosed(Message inMessage)
	{
	}

	public static void Close()
	{
	}

	[IteratorStateMachine(typeof(<LoadLevel>d__30))]
	public IEnumerator LoadLevel(string inLevelName, string inLevelNameAdditive)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadLevel>d__31))]
	public IEnumerator LoadLevel(string inLevelName, List<string> inLevelNameAdditives)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadNextLevel>d__32))]
	private IEnumerator LoadNextLevel()
	{
		return null;
	}

	private void CloseAllWindows()
	{
	}

	private void LoadingTimeout()
	{
	}

	private void LoadingStart()
	{
	}

	private void LoadingFinish()
	{
	}
}
