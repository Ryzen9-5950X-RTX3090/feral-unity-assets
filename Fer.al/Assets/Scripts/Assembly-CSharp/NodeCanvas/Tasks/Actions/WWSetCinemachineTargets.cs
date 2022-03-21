using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Set Cinemachine Targets", 0)]
	[Category("WildWorks/CineMachine")]
	[Description("Sets or clears the targets on a Cinemachine camera.")]
	public class WWSetCinemachineTargets : ActionTask<CinemachineVirtualCamera>
	{
		public BBParameter<Transform> followTarget;

		public bool clearFollowTarget;

		public BBParameter<Transform> aimTarget;

		public bool clearAimTarget;

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
	}
}
