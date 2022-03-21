using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FeralAnimationEvents : ScriptableObject
{
	public enum EFXPlayState
	{
		PLAY,
		PLAY_ONESHOT,
		KILL,
		KILL_ON_EXIT
	}

	public enum EFXSpawnState
	{
		NONE,
		SPAWN,
		DESPAWN
	}

	[Serializable]
	public class EventInfo
	{
		[Header("AUDIO")]
		public FeralAudioInfo feralAudioInfo;

		[HideInInspector]
		public string eventFunctionName;

		[HideInInspector]
		public string eventStringParameter;

		[Header("FX")]
		[RootSelector("Fx BundleId", "BundleIDChartData", false, false)]
		public string fxBundleId;

		public string fxAttachmentNode;

		public EFXPlayState playState;

		public FXInfo fXInfo;

		internal EventInfo killEventInfo;
	}

	public class FXInfo
	{
		[HideInInspector]
		public GameObject refObject;

		[HideInInspector]
		public string spawnedFxDefId;

		[HideInInspector]
		public EFXSpawnState eSpawnState;
	}

	[Serializable]
	public class AnimationEventInfo
	{
		public List<EventInfo> eventInfos;
	}

	[NonSerialized]
	private static Dictionary<string, EventInfo> _cachedEvents;

	[NonSerialized]
	private static bool _eventsCached;

	public List<AnimationEventInfo> animationEventInfos;

	public static Dictionary<string, EventInfo> cachedEvents
	{
		get
		{
			return null;
		}
	}

	public static void ClearCache()
	{
	}
}
