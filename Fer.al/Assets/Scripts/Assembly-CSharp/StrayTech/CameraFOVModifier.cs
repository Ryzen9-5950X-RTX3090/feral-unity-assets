using StrayTech.CustomAttributes;
using UnityEngine;

namespace StrayTech
{
	public class CameraFOVModifier : CameraStateModifierBase
	{
		[NonNegative]
		[SerializeField]
		[Tooltip("The Field of View that this modifier adjusts the camera to when it's active.")]
		public float _fieldOfView;

		private float _cachedFoV;

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

		public override void Cleanup()
		{
		}
	}
}
