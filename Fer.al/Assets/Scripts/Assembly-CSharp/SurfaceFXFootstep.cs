using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class SurfaceFXFootstep : ManagedBehaviour
{
	[EventRef]
	public string Event;

	[Range(0f, 1f)]
	public float waterLevel;

	[Range(0f, 1f)]
	public float grassLevel;

	[Range(0f, 1f)]
	public float dirtLevel;

	[Range(0f, 1f)]
	public float woodLevel;

	[Range(0f, 1f)]
	public float stoneLevel;

	[Range(0f, 1f)]
	public float snowLevel;

	[Range(0f, 1f)]
	public float iceLevel;

	public static Dictionary<string, float> MixedLevels;

	private EventInstance? _eventInstance;

	public bool bankLoaded
	{
		get
		{
			return default(bool);
		}
	}

	private EventInstance? eventInstance
	{
		get
		{
			return null;
		}
	}

	private void SetTerrainParams(EventInstance inEventInstance, bool testBlending = false)
	{
	}

	private void SetAvatarParams(EventInstance inEventInstance)
	{
	}

	private void SetParameter(EventInstance inEventInstance, string pName, float pValue)
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}
}
