using System.Collections;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Set Cinemachine Field of View", 0)]
	[Category("WildWorks/CineMachine")]
	[Description("Sets the field of view on a Cinemachine camera with optional delay and transit time.")]
	public class WWSetCinemachineFieldOfView : ActionTask<CinemachineVirtualCamera>
	{
		public BBParameter<float> fieldOfView;

		public float delay;

		public float transitTime;

		public Interpolation.InterpolationType interpolationType;

		public bool waitForFinish;

		private float currentValue;

		private float myElapsedTime;

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

		[IteratorStateMachine(typeof(<ExecuteCoroutine>d__10))]
		private IEnumerator ExecuteCoroutine()
		{
			return null;
		}
	}
}
