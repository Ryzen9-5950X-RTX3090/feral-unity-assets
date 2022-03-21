using System.Collections;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Send a camera shake impulse.")]
	public class LocalPlayerScreenShake : ActionTask<CinemachineImpulseSource>
	{
		public enum DurationsType
		{
			AgentBased,
			NodeValues
		}

		public DurationsType durationsType;

		[ShowIf("durationsType", 1)]
		public BBParameter<float> fadeInTime;

		[ShowIf("durationsType", 1)]
		public BBParameter<float> sustainTime;

		[ShowIf("durationsType", 1)]
		public BBParameter<float> fadeOutTime;

		public BBParameter<float> intensity;

		public BBParameter<bool> useLocalPlayerPosition;

		public BBParameter<bool> waitToContinue;

		private float _oldFadeIn;

		private float _oldSustain;

		private float _oldFadeOut;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<Chill>d__14))]
		private IEnumerator Chill(float inWait)
		{
			return null;
		}
	}
}
