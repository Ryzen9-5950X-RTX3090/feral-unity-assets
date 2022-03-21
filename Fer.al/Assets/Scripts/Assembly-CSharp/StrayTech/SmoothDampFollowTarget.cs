using UnityEngine;

namespace StrayTech
{
	public class SmoothDampFollowTarget : MonoBehaviour
	{
		[SerializeField]
		private Transform _followTarget;

		[SerializeField]
		private Vector3 _targetOffset;

		[SerializeField]
		private float _smoothTime;

		[SerializeField]
		private bool _useFixedUpdate;

		private Vector3[] _vector3s;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void DoUpdate(float deltaTime)
		{
		}
	}
}
