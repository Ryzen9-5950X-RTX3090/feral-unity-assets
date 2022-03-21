using UnityEngine;

namespace Prototype
{
	public class SpawnModel : ManagedBehaviour
	{
		[SerializeField]
		private GameObject _modelPrefab;

		[SerializeField]
		private RuntimeAnimatorController _animatorController;

		[SerializeField]
		private float _scale;

		private Animator _animator;

		public override void MStart()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
