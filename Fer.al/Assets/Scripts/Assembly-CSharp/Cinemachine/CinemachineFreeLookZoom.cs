using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[RequireComponent(typeof(CinemachineFreeLook))]
	internal class CinemachineFreeLookZoom : MonoBehaviour
	{
		private CinemachineFreeLook freelook;

		public CinemachineFreeLook.Orbit[] originalOrbits;

		[Tooltip("The minimum scale for the orbits")]
		[Range(0.01f, 1f)]
		public float minScale;

		[Tooltip("The maximum scale for the orbits")]
		[Range(1f, 5f)]
		public float maxScale;

		[AxisStateProperty]
		[Tooltip("The Vertical axis.  Value is 0..1.  How much to scale the orbits")]
		public AxisState zAxis;

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateZoom()
		{
		}

		private float Log_erp(float a, float b, float t)
		{
			return default(float);
		}
	}
}
