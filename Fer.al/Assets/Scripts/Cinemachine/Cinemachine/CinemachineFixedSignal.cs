using UnityEngine;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineImpulseFixedSignals.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineFixedSignal : SignalSourceAsset
	{
		[Tooltip("The raw signal shape along the X axis")]
		public AnimationCurve m_XCurve;

		[Tooltip("The raw signal shape along the Y axis")]
		public AnimationCurve m_YCurve;

		[Tooltip("The raw signal shape along the Z axis")]
		public AnimationCurve m_ZCurve;

		public override float SignalDuration
		{
			get
			{
				return default(float);
			}
		}

		private float AxisDuration(AnimationCurve axis)
		{
			return default(float);
		}

		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
		{
		}

		private float AxisValue(AnimationCurve axis, float time)
		{
			return default(float);
		}
	}
}
