using UnityEngine;

namespace StrayTech
{
	public class CameraStateTransitionTrigger : CameraSystemTriggerBase
	{
		[SerializeField]
		[Tooltip("The target Camera State Definition to transition to.")]
		private CameraStateDefinition _targetCameraStateDefinition;

		public CameraStateDefinition TargetCameraStateDefinition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void TriggerEntered()
		{
		}

		protected override void TriggerExited()
		{
		}
	}
}
