using UnityEngine;

namespace StrayTech
{
	[RequireComponent(typeof(Character))]
	public class CharacterControl : MonoBehaviour
	{
		public CameraStateDefinition cameraStateOrbit;

		private Character _character;

		private Vector3 _camForward;

		private Vector3 _move;

		private bool _jump;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
