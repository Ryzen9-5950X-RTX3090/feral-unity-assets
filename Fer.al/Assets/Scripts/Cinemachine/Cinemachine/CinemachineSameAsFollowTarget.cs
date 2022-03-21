using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[SaveDuringPlay]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("")]
	public class CinemachineSameAsFollowTarget : CinemachineComponentBase
	{
		[Tooltip("How much time it takes for the aim to catch up to the target's rotation")]
		[FormerlySerializedAs("m_AngularDamping")]
		public float m_Damping;

		private Quaternion m_PreviousReferenceOrientation;

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
