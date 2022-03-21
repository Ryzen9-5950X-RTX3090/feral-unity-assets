using FMOD.Studio;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace FMODUnity
{
	public class FMODEventPlayableBehavior : PlayableBehaviour
	{
		public string eventName;

		public STOP_MODE stopType;

		public ParamRef[] parameters;

		public GameObject TrackTargetObject;

		public TimelineClip OwningClip;

		private bool isPlayheadInside;

		private EventInstance eventInstance;

		protected void PlayEvent()
		{
		}

		public void OnEnter()
		{
		}

		public void OnExit()
		{
		}

		public void UpdateBehaviour(float time)
		{
		}

		public override void OnGraphStop(Playable playable)
		{
		}
	}
}
