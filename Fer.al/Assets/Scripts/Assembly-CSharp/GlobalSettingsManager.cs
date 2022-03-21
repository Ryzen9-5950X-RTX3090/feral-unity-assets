using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class GlobalSettingsManager : CoreGlobalSettingsManager
{
	[Header("Feral Debug")]
	public bool noAutoLoginInEditor;

	public bool autoPressLoginButton;

	[Header("Offline Mode (Fake Server)")]
	public bool forceOfflineMode;

	public string defaultSanctuaryLevelDefId;

	[SetInstance]
	public static GlobalSettingsManager instance;

	private int _averageFPS;

	public override string PostSplashScene
	{
		get
		{
			return null;
		}
	}

	public override string ProjectDefine
	{
		get
		{
			return null;
		}
	}

	public override string DataServerProject
	{
		get
		{
			return null;
		}
	}

	public override string ProjectSVNURL
	{
		get
		{
			return null;
		}
	}

	protected override string DevBaseURL
	{
		get
		{
			return null;
		}
	}

	protected override string StageBaseURL
	{
		get
		{
			return null;
		}
	}

	protected override string ProdBaseURL
	{
		get
		{
			return null;
		}
	}

	protected override string DevSharedBaseURL
	{
		get
		{
			return null;
		}
	}

	protected override string StageSharedBaseURL
	{
		get
		{
			return null;
		}
	}

	protected override string SharedBaseURL
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<SetAverageFps>d__27))]
	private IEnumerator SetAverageFps()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SendFpsAnalytics>d__28))]
	private IEnumerator SendFpsAnalytics()
	{
		return null;
	}

	public Coroutine SetLanguage(SystemLanguage inNewLanguage, [Optional] Action inCallback)
	{
		return null;
	}

	public string GetPlatformString()
	{
		return null;
	}
}
