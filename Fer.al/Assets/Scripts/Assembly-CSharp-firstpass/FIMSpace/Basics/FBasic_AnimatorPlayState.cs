using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_AnimatorPlayState : MonoBehaviour
	{
		public string AnimationStateName;

		public int AnimationLayer;

		[Tooltip("Normalized time so go from 0 to 1")]
		public Vector2 TimeOffset;

		private void Start()
		{
		}
	}
}
