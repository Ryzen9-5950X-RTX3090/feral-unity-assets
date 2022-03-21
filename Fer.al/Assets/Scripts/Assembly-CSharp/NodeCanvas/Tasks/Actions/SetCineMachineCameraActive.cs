using System.Collections;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/CineMachine")]
	[Description("Sets a CineMachine Camera game object active or inactive.")]
	public class SetCineMachineCameraActive : ActionTask<GameObject>
	{
		public BBParameter<CinemachineVirtualCamera> cinemachineVirtualCamera;

		public BBParameter<bool> setActive;

		public BBParameter<FeralAudioEmitter> audioEmitter;

		public BBParameter<float> audioDelay;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<ReEnable>d__8))]
		private IEnumerator ReEnable(CinemachineVirtualCamera inVirtualCamera)
		{
			return null;
		}
	}
}
