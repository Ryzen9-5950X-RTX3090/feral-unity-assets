using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

public class Reset : CoreReset
{
	private bool _clearScriptableObjects;

	private bool _clearMaterials;

	private bool _clearRenderTextures;

	private bool _clearTextures;

	private bool _clearRuntimeAnimatorControllers;

	private bool _clearAnimationClips;

	private bool _clearFonts;

	private bool _clearTextAssets;

	private bool _clearParticleSystemRenderers;

	private bool _clearParticleSystems;

	private bool _clearMeshes;

	private bool _clearAudioMixers;

	private bool _clearAudioMixerGroups;

	private bool _clearAudioClips;

	private bool _clearActorBases;

	private bool _clearTransforms;

	private bool _clearGameObjects;

	private bool _clearMonoBehaviours;

	protected override string _name
	{
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}

	[DebugButton("Core Reset", "Reset", true, true)]
	public static void DoCoreReset()
	{
	}

	[DebugButton("Reset with SplashErrorName,ErrorCodeInt", "Reset", true, true)]
	public static void DoCoreResetWithErrorCode(string arguments)
	{
	}

	[DebugButton("Show SplashErrorNames Debug.Log()", "Reset", true, false)]
	public static void ShowSplashErrorNames()
	{
	}

	[DebugButton("Show ErrorCodes Debug.Log()", "Reset", true, false)]
	public static void ShowErrorCodes()
	{
	}

	[IteratorStateMachine(typeof(<LoadLoadingScene>d__7))]
	private IEnumerator LoadLoadingScene(Action<bool> callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ResetCoroutine>d__8))]
	protected override IEnumerator ResetCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ClearObjects>d__27))]
	private IEnumerator ClearObjects()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Delay>d__28))]
	private IEnumerator Delay()
	{
		return null;
	}
}
