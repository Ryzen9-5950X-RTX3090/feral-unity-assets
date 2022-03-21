using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class CameraStateModifierTrigger : CameraSystemTriggerBase
	{
		[SerializeField]
		[Tooltip("The target Camera Modifier to enable and/or disable.")]
		private CameraStateModifierBase _cameraStateModifierTarget;

		[SerializeField]
		[Tooltip("Ignore the OnTriggerExit event?")]
		private bool _ignoreTriggerExit;

		private bool _inTrigger;

		private bool _selfieCamActive;

		private bool InTrigger
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private bool SelfieCamActive
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void TriggerEntered()
		{
		}

		protected override void TriggerExited()
		{
		}

		private void OnPlayerCameraChanged(PlayerCameraMessage inMessage)
		{
		}

		private void EnableMod()
		{
		}

		private void DisableMod()
		{
		}

		[IteratorStateMachine(typeof(<InternalSetMod>d__17))]
		private IEnumerator InternalSetMod(bool inEnabled)
		{
			return null;
		}
	}
}
