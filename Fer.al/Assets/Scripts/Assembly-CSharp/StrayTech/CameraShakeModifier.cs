using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public class CameraShakeModifier : CameraStateModifierBase
	{
		[SerializeField]
		[Tooltip("Defines the duration and intensity multiplier of the camera shake.")]
		private AnimationCurve _shakeIntensityMultiplierCurve;

		[SerializeField]
		[Tooltip("The base intensity of the camera shake.")]
		private float _shakeIntensity;

		private Vector3 _positionOffset;

		private Quaternion _rotationOffset;

		private float _shakeDuration;

		private float _shakeLerpT;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		protected override void CalculateModification(ICameraState cameraState, float deltaTime)
		{
		}

		public override bool Enable()
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<DoCurveBasedCameraShake>d__10))]
		private IEnumerator DoCurveBasedCameraShake()
		{
			return null;
		}
	}
}
