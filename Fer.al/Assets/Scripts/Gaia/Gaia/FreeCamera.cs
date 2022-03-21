using UnityEngine;

namespace Gaia
{
	public class FreeCamera : MonoBehaviour
	{
		public bool enableInputCapture;

		public bool lockAndHideCursor;

		public bool holdRightMouseCapture;

		public float lookSpeed;

		public float moveSpeed;

		public float sprintSpeed;

		private bool m_inputCaptured;

		private float m_yaw;

		private float m_pitch;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private void CaptureInput()
		{
		}

		private void ReleaseInput()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		private void Update()
		{
		}
	}
}
