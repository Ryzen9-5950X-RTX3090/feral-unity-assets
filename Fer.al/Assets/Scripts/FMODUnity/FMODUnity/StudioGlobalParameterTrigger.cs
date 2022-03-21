using FMOD;
using FMOD.Studio;
using UnityEngine;

namespace FMODUnity
{
	[AddComponentMenu("FMOD Studio/FMOD Studio Global Parameter Trigger")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[ParamRef]
		public string parameter;

		public EmitterGameEvent TriggerEvent;

		public float value;

		private PARAMETER_DESCRIPTION parameterDescription;

		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		private RESULT Lookup()
		{
			return default(RESULT);
		}

		private void Awake()
		{
		}

		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		public void TriggerParameters()
		{
		}
	}
}
