using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class FeralAudioManager : CoreAudioManager
{
	[Serializable]
	public class BankInfo
	{
		public string bankName;

		public Bank? bank;

		public EBankState bankState;

		public GameObject bankGameObject;

		public List<string> events;
	}

	[SetInstance]
	public static FeralAudioManager instance;

	private Coroutine _clearMemoryCoroutine;

	public string FMOD_Project_Name;

	private GameObject _audioListener;

	private List<string> _banksLoading;

	private int? _maxBankLoads;

	private float? _loadingTimeout;

	private string _sourceBankAssetPath;

	private VCA? _musicVCA;

	private VCA? _sfxVCA;

	private Coroutine _musicVolumeChangedInit;

	private Coroutine _sfxVolumeChangedInit;

	private bool _masterBankStringsLoaded;

	private bool _masterBankAssetLoaded;

	private string _masterMusicPath;

	private string _masterSfxPath;

	private Dictionary<GameObject, FeralAudioBehaviour> feralAudioBehaviours;

	public List<BankInfo> bankInfos;

	public List<string> _bankLoadsInProgress;

	public GameObject audioListener
	{
		get
		{
			return null;
		}
	}

	public GameObject AudioListenerOverride
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private int maxBankLoads
	{
		get
		{
			return default(int);
		}
	}

	private float loadingTimeout
	{
		get
		{
			return default(float);
		}
	}

	private string sourceBankAssetPath
	{
		get
		{
			return null;
		}
	}

	public FeralAnimationEvents feralAnimationAudio
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

	public bool initialized
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

	[IteratorStateMachine(typeof(<InitCoroutine>d__40))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadAudio>d__41))]
	private IEnumerator LoadAudio()
	{
		return null;
	}

	private void AddListeners(bool inAdd)
	{
	}

	[IteratorStateMachine(typeof(<LoadMasterBankStrings>d__43))]
	private IEnumerator LoadMasterBankStrings()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadMasterBankAsset>d__44))]
	private IEnumerator LoadMasterBankAsset()
	{
		return null;
	}

	public void FeralAudioInfoMessage(FeralAudioMessage inMessage)
	{
	}

	public LOADING_STATE BankIsLoadedForEvent(string inEventName)
	{
		return default(LOADING_STATE);
	}

	public override void MUpdate()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnLoadingFinished(Message inMessage)
	{
	}

	public void PlayAudio(AudioScriptableObject inAudioScriptableObject, GameObject inGameObject)
	{
	}

	public void Add(GameObject inGameObject, FeralAudioBehaviour inAudioBehaviour)
	{
	}

	public void Remove(GameObject inGameObject)
	{
	}

	public void StopAllInstances()
	{
	}

	public void KillAllInstances()
	{
	}

	public string GetBankName(string inEvent)
	{
		return null;
	}

	public void LoadBank(FeralAudioInfo inAudioInfo, [Optional] GameObject inGameObject, [Optional] Action<bool> Callback)
	{
	}

	[IteratorStateMachine(typeof(<LoadBankRoutine>d__57))]
	private IEnumerator LoadBankRoutine(FeralAudioInfo inAudioInfo, string inBankName, GameObject inGameObject, Action<bool> Callback)
	{
		return null;
	}

	private void ClearMemory()
	{
	}

	[IteratorStateMachine(typeof(<ClearMemoryCoroutine>d__59))]
	private IEnumerator ClearMemoryCoroutine()
	{
		return null;
	}

	private bool BankIsLoading(string inBankName)
	{
		return default(bool);
	}

	private void AddToLoadingProgress(string inBankName)
	{
	}

	private void RemoveFromLoadingProgress(string inBankName)
	{
	}

	private void AddAudioInfo(BankInfo inBankInfo, FeralAudioInfo inAudioInfo)
	{
	}

	public static bool ValidEvent(FeralAudioInfo inAudioInfo)
	{
		return default(bool);
	}

	private BankInfo BankInfoExists(string inBankName)
	{
		return null;
	}

	public void UnloadAllBanks()
	{
	}

	private bool UnloadBank(string inBankName)
	{
		return default(bool);
	}

	private BankInfo CreateBankInfo(string inBankName, GameObject inBankGameObject)
	{
		return null;
	}

	private BankInfo CreateBankInfo(string inBankName, GameObject inBankGameObject, bool inAllowBankInfoCreation = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadBankFromTextAssetCoroutine>d__70))]
	private IEnumerator LoadBankFromTextAssetCoroutine(TextAsset inTextAsset, GameObject inBankGameObject, bool inAllowBankInfoCreation, Action<bool> aLoaded)
	{
		return null;
	}

	private void UnloadBankFromAsset(BankInfo inBankInfo)
	{
	}

	public override void SoundVolumeChanged(float inVolume)
	{
	}

	public override void MusicVolumeChanged(float inVolume)
	{
	}

	[IteratorStateMachine(typeof(<SoundVolumeChangedInit>d__74))]
	private IEnumerator SoundVolumeChangedInit(float inVolume)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MusicVolumeChangedInit>d__75))]
	private IEnumerator MusicVolumeChangedInit(float inVolume)
	{
		return null;
	}

	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, ParamRef inParamRef)
	{
	}

	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, FeralAudioParameter inFeralAudioParameter)
	{
	}

	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, string inParameterName, [Optional] float? inParameterValue)
	{
	}

	private void CheckParametersBeforePlay(GameObject inGameObject, FeralAudioInfo inAudioInfo, [Optional] ParamRef inParamRef, [Optional] FeralAudioParameter inFeralAudioParameter, [Optional] string inSetParameterString, [Optional] string inParameterName, [Optional] float? inParameterValue)
	{
	}

	private void DoPlay(GameObject inGameObject, FeralAudioInfo inAudioInfo, [Optional] string inParameterName, [Optional] float? inParameterValue)
	{
	}

	public void StopEventOnGameObject(string inEventRef, GameObject inGameObject)
	{
	}

	public void Stop(FeralAudioInfo inAudioInfo, [Optional] GameObject inGameObject)
	{
	}

	public void Kill(FeralAudioInfo inAudioInfo)
	{
	}

	public void MuteAllEvents(bool inMute)
	{
	}

	public void PauseAllEvents(bool inPause)
	{
	}

	public void LoadAudioActor(AudioActorNoSO inAudioActor, GameObject inGameObject)
	{
	}
}
