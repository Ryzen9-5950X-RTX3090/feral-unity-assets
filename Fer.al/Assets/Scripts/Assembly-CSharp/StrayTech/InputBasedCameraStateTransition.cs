using UnityEngine;

namespace StrayTech
{
	public class InputBasedCameraStateTransition : MonoBehaviour
	{
		[SerializeField]
		private CameraStateDefinition[] _cameraStateDefinitionArray;

		[SerializeField]
		private KeyCode _transitionKey;

		private int _currentStateIndex;

		private bool _pressedLastFrame;

		private void Update()
		{
		}
	}
}
