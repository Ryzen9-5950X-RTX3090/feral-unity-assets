using UnityEngine;

namespace StrayTech
{
	public class LookAtTargetModifier : CameraStateModifierBase
	{
		[SerializeField]
		[Tooltip("The target Transform to look at.")]
		private Transform _lookAtTarget;

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
