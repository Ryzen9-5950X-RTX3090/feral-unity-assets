using UnityEngine;

namespace Gaia
{
	[RequireComponent(typeof(ReflectionProbe))]
	public class GaiaReflectionProbeUpdate : MonoBehaviour
	{
		public enum ReflectionQuality
		{
			VeryLow,
			Low,
			Medium,
			High,
			VeryHigh,
			Ultra
		}

		public enum RenderDistanceQuality
		{
			Close,
			Near,
			Far,
			VeryFar,
			ExtremelyFar
		}

		[Header("Probe Configuration [Applied OnStart]")]
		[Tooltip("Sets the probe reflection quality")]
		public ReflectionQuality m_probeResolution;

		[Tooltip("Sets the probe render distance")]
		public RenderDistanceQuality m_probeRenderDistance;

		[Tooltip("If on the reflection probe will follow the camera position")]
		public bool m_followCamera;

		[Tooltip("Offset above the camera that probe will be adjusted by when following camera. Zero gives more accurate reflections, but captures surrounding trees and other objects.")]
		public float m_followHeightOffset;

		[Tooltip("Sets box projection")]
		public bool m_boxProjection;

		[Tooltip("Sets hdr on the reflection probe")]
		public bool m_useHDR;

		private int m_renderID;

		private ReflectionProbe m_reflectionProbe;

		private bool m_cameraIsMoving;

		private Vector3 m_lastLocation;

		public GameObject m_mainCameraObject;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetProbeSettings()
		{
		}

		public void ProbeFollow()
		{
		}

		private static GameObject GetOrCreateMainCamera()
		{
			return null;
		}
	}
}
