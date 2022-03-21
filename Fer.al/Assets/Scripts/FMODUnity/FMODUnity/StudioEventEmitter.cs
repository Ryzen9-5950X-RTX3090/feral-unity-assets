using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using UnityEngine;

namespace FMODUnity
{
	[AddComponentMenu("FMOD Studio/FMOD Studio Event Emitter")]
	public class StudioEventEmitter : EventHandler
	{
		[EventRef]
		public string Event;

		public EmitterGameEvent PlayEvent;

		public EmitterGameEvent StopEvent;

		public bool AllowFadeout;

		public bool TriggerOnce;

		public bool Preload;

		public ParamRef[] Params;

		public bool OverrideAttenuation;

		public float OverrideMinDistance;

		public float OverrideMaxDistance;

		protected EventDescription eventDescription;

		protected EventInstance instance;

		private bool hasTriggered;

		private bool isQuitting;

		private bool isOneshot;

		private List<ParamRef> cachedParams;

		private const string SnapshotString = "snapshot";

		public EventDescription EventDescription
		{
			get
			{
				return default(EventDescription);
			}
		}

		public EventInstance EventInstance
		{
			get
			{
				return default(EventInstance);
			}
		}

		public bool IsActive
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

		public float MaxDistance
		{
			get
			{
				return default(float);
			}
		}

		private void Start()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		private void Lookup()
		{
		}

		public void Play()
		{
		}

		public void PlayInstance()
		{
		}

		public void Stop()
		{
		}

		public void StopInstance()
		{
		}

		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		public bool IsPlaying()
		{
			return default(bool);
		}
	}
}
