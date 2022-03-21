using UnityEngine;

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode]
	public class UIParticleOverlayCamera : MonoBehaviour
	{
		private Camera m_Camera;

		private static UIParticleOverlayCamera s_Instance;

		public static UIParticleOverlayCamera instance
		{
			get
			{
				return null;
			}
		}

		private Camera cameraForOvrelay
		{
			get
			{
				return null;
			}
		}

		public static Camera GetCameraForOvrelay(Canvas canvas)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
