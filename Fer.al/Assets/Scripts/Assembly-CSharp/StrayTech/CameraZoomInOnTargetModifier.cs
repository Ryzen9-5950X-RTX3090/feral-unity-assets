using StrayTech.CustomAttributes;
using UnityEngine;

namespace StrayTech
{
	public class CameraZoomInOnTargetModifier : CameraStateModifierBase
	{
		[SerializeField]
		[Tooltip("The target to zoom in on.")]
		private Transform _target;

		[SerializeField]
		[Tooltip("The offset from target.")]
		private Vector3 _targetOffset;

		[SerializeField]
		[NonNegative]
		[Tooltip("The distance to zoom into from target.")]
		private float _distanceFromTarget;

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
	}
}
