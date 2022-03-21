using System;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class FeralAudioInfo
{
	[EventRef]
	public string eventRef;

	[SerializeField]
	[Header("Variables")]
	private bool _allowFadeout;

	[SerializeField]
	private bool _triggerOnce;

	[SerializeField]
	private GameObject _attachToOverride;

	[SerializeField]
	[Header("Parameters")]
	[FormerlySerializedAs("parameters")]
	private ParamRef[] _parameters;

	private string _bankName;

	[SerializeField]
	[Header("Mod Parameter")]
	private FeralAudioParameter[] _modParameter;

	[SerializeField]
	[Header("Attenuation")]
	private bool _overrideAttenuation;

	[SerializeField]
	private float _overrideMinDistance;

	[SerializeField]
	private float _overrideMaxDistance;

	public EventInstance eventInstance;

	public EventDescription eventDescription;

	public bool allowFadeout
	{
		get
		{
			return default(bool);
		}
	}

	public bool triggerOnce
	{
		get
		{
			return default(bool);
		}
	}

	public GameObject attachToOverride
	{
		get
		{
			return null;
		}
	}

	public ParamRef[] parameters
	{
		get
		{
			return null;
		}
	}

	public string bankName
	{
		get
		{
			return null;
		}
	}

	public FeralAudioParameter[] modParameter
	{
		get
		{
			return null;
		}
	}

	public bool overrideAttenuation
	{
		get
		{
			return default(bool);
		}
	}

	public float overrideMinDistance
	{
		get
		{
			return default(float);
		}
	}

	public float overrideMaxDistance
	{
		get
		{
			return default(float);
		}
	}

	private FeralAudioManager GetAudioManager()
	{
		return null;
	}

	public void Play(GameObject inGameObject)
	{
	}

	public void Play(GameObject inGameObject, string inParameter)
	{
	}

	public void Play(GameObject inGameObject, string inParameter, float inValue)
	{
	}

	public void Play(GameObject inGameObject, ParamRef inParameter)
	{
	}

	public void Play(GameObject inGameObject, FeralAudioParameter inParameter)
	{
	}

	public void Load(GameObject inGameObject)
	{
	}

	public void Stop(GameObject inGameObject)
	{
	}

	public void SetParameters(GameObject inGameObject, ParamRef[] inParameters)
	{
	}

	public void SetParameter(GameObject inGameObject, string inParameter, float inValue)
	{
	}

	public void SetParameter(GameObject inGameObject, ParamRef inParameter)
	{
	}

	public void SetParameter(GameObject inGameObject, FeralAudioParameter inParameter)
	{
	}

	public void SetParameter(GameObject inGameObject, string inParameter)
	{
	}

	public void Kill(GameObject inGameObject)
	{
	}
}
