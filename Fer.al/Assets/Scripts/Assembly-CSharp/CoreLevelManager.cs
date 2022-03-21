using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoreLevelManager : CoreManagerBase<CoreLevelManager>
{
	public static string startScene;

	private Coroutine _progressBarRoutine;

	private LevelDefComponent _currentLevelDef;

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

	public LevelDefComponent CurrentLevelDef
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CurrentLevelID
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string PreviousLevelID
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

	public LevelDefComponent PreviousLevelDef
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static void LoadLevelSingle(string inLevelName)
	{
	}

	public static void LoadLevelAdditive(string inLevelName)
	{
	}

	public static AsyncOperation LoadLevelAdditiveAsync(string inLevelName)
	{
		return null;
	}

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<FakeLoadCurrentLevel>d__24))]
	public static IEnumerator FakeLoadCurrentLevel()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadLevel>d__25))]
	public IEnumerator LoadLevel(string inDefID, bool inFakeLoad = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DownloadProgress>d__26))]
	private IEnumerator DownloadProgress(ManifestDef inManifestDef)
	{
		return null;
	}

	public virtual void InitCurrentLevel()
	{
	}

	public virtual bool WaitBeforeFadeOut()
	{
		return default(bool);
	}

	public virtual void OnFinishLoading()
	{
	}
}
