using UnityEngine;

namespace StrayTech
{
	public class DirectionalTriggerGate : MonoBehaviour, ITriggerGate
	{
		[SerializeField]
		[Range(0f, 360f)]
		[Tooltip("The primary direction the volume can be triggered from.")]
		private float _angle;

		[SerializeField]
		[Range(0f, 180f)]
		[Tooltip("The span of the primary direction the volume can be triggered from.")]
		private float _angleSpan;

		private bool _enteredFromValidDirection;

		private Vector3 _validDirection;

		public bool IsActive
		{
			get
			{
				return default(bool);
			}
		}

		private void Start()
		{
		}

		public void TriggerWasEntered(Collider other)
		{
		}

		public bool IsTriggerBlocked()
		{
			return default(bool);
		}
	}
}
