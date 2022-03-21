using UnityEngine;

namespace Prototype
{
	public class FacePlayer : ManagedBehaviour
	{
		[SerializeField]
		private float _targetFacingRotationSpeed;

		private Transform _playerTransform;

		private Transform playerTransform
		{
			get
			{
				return null;
			}
		}

		private Vector3 _relativePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public override void MUpdate()
		{
		}
	}
}
