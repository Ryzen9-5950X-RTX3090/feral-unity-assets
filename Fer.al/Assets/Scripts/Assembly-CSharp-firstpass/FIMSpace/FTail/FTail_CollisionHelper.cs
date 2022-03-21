using UnityEngine;

namespace FIMSpace.FTail
{
	public class FTail_CollisionHelper : MonoBehaviour
	{
		public FTail_AnimatorBase ParentTail;

		public int index;

		private Transform previousCollision;

		internal FTail_CollisionHelper Init(bool addRigidbody = true)
		{
			return null;
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}
	}
}
