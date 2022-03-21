using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FMODUnity;
using UnityEngine;

public class FeralAudioMessage
{
	public enum EState
	{
		LOAD,
		PLAY,
		STOP,
		KILL
	}

	public Item item
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public FeralAudioInfo audioInfo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public GameObject attach
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public ParamRef paramRef
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public FeralAudioParameter feralAudioParameter
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public string stringParameter
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public string parameterName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public float? parameterValue
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public EState state
	{
		[CompilerGenerated]
		get
		{
			return default(EState);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	private FeralAudioMessage(FeralAudioInfo inAudioInfo, EState inState = EState.PLAY, [Optional] GameObject inGameObject, [Optional] ParamRef inParameterRef, [Optional] FeralAudioParameter inFeralAudioParameter, [Optional] string inStringParameter, [Optional] string inParameterName, [Optional] float? inParameterValue)
	{
	}

	public static FeralAudioMessage Create(FeralAudioInfo inAudioInfo, EState inState = EState.PLAY, [Optional] GameObject inGameObject, [Optional] ParamRef inParameterRef, [Optional] FeralAudioParameter inFeralAudioParameter, [Optional] string inStringParameter, [Optional] string inParameterName, [Optional] float? inParameterValue)
	{
		return null;
	}
}
