using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class CameraStateModifierTimedTrigger : CameraSystemTriggerBase
	{
		[SerializeField]
		[Tooltip("The target Camera Modifier to enable and/or disable.")]
		private CameraStateModifierBase _cameraStateModifierTarget;

		[SerializeField]
		[Tooltip("The modifier will be disabled after this duration.")]
		private float _enabledDuration;

		protected override void TriggerEntered()
		{
		}

		protected override void TriggerExited()
		{
		}

		[IteratorStateMachine(typeof(<DoTimedDisable>d__4))]
		private IEnumerator DoTimedDisable()
		{
			return null;
		}
	}
}
