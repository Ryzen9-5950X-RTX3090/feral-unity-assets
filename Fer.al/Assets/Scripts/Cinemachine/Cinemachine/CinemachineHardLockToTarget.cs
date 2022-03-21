using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineHardLockToTarget : CinemachineComponentBase
	{
		[Tooltip("How much time it takes for the position to catch up to the target's position")]
		public float m_Damping;

		private Vector3 m_PreviousTargetPosition;

		public override bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public override CinemachineCore.Stage Stage
		{
			get
			{
				return default(CinemachineCore.Stage);
			}
		}

		public override float GetMaxDampTime()
		{
			return default(float);
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}
