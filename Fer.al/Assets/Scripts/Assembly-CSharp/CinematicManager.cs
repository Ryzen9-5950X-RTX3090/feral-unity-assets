using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WW.Debug;

public class CinematicManager : SingletonManagerBase<CinematicManager>
{
	private const string _cutscenesGroup = "Cutscenes";

	private const string _availableCutscenesGroup = "Cutscenes/Available Cutscenes";

	private const string _allCutscenesGroup = "Cutscenes/All Cutscenes";

	private const string _resetDataGroup = "Cutscenes/Reset";

	private readonly IDictionary<string, Cutscene> _cutsceneLookup;

	private Cutscene _cutsceneToPlayOnLevelLoad;

	public static bool Initialized
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

	public bool IsAutoPlayFunctionalityEnabled
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCutsceneActive
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsTestRunActive
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

	public Cutscene CurrentlyPlayingCutscene
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

	public Cutscene[] AvailableCutscenes
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

	public Cutscene[] AllCutsceneNames
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

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public bool TryPlayCutscene(Cutscene cutscene)
	{
		return default(bool);
	}

	[DebugButton("Play Cutscene", "Cutscenes", false, false)]
	public bool TryPlayCutscene(string cutscene)
	{
		return default(bool);
	}

	[DebugButton("Force Play Cutscene", "Cutscenes", false, false)]
	public bool TryForcePlayCutscene(string cutscene)
	{
		return default(bool);
	}

	[DebugButton("Skip Cutscene", "Cutscenes", false, false)]
	public void TrySkipCutscene()
	{
	}

	[DebugButton("Force Skip Cutscene", "Cutscenes", false, false)]
	public bool TryForceSkipCutscene()
	{
		return default(bool);
	}

	private bool TryPlayCutscene(string cutscene, bool force)
	{
		return default(bool);
	}

	private bool TryPlayCutscene(Cutscene cutscene, bool force)
	{
		return default(bool);
	}

	private bool TrySkipCutscene(bool force)
	{
		return default(bool);
	}

	private bool TryGetCutscene(string cutscene, out Cutscene matchingCutscene, bool requireInitialization = true)
	{
		return default(bool);
	}

	private void OnCutsceneEnded(CutscenePlaybackState playbackState)
	{
	}

	private void Reload(Message message)
	{
	}

	private void InitializeCutscene(Cutscene cutscene)
	{
	}
}
