using UnityEngine;

namespace Rewired.Demos
{
	[AddComponentMenu("")]
	[RequireComponent(typeof(CharacterController))]
	public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
	{
		public int playerId;

		public float moveSpeed;

		public float bulletSpeed;

		public GameObject bulletPrefab;

		private CharacterController cc;

		private Vector3 moveVector;

		private bool fire;

		private Player player
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void GetInput()
		{
		}

		private void ProcessInput()
		{
		}
	}
}
