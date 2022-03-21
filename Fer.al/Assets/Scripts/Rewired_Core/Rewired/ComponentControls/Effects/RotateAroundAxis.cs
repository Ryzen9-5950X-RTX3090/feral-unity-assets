using UnityEngine;

namespace Rewired.ComponentControls.Effects
{
	public class RotateAroundAxis : MonoBehaviour
	{
		public enum Speed
		{
			Stopped,
			Slow,
			Fast
		}

		public enum RotationAxis
		{
			X,
			Y,
			Z
		}

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The current speed of rotation.")]
		private Speed _speed;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The speed of rotation when Speed is set to Slow. This measured in degrees per second.")]
		private float _slowRotationSpeed;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The speed of rotation when Speed is set to Fast. This measured in degrees per second.")]
		private float _fastRotationSpeed;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The axis around which rotation will occur.")]
		private RotationAxis _rotateAroundAxis;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The space in which rotation will occur.")]
		private Space _relativeTo;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Reverses the rotation direction.")]
		private bool _reverse;

		public Speed speed
		{
			get
			{
				return default(Speed);
			}
			set
			{
			}
		}

		public float slowRotationSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float fastRotationSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public RotationAxis rotateAroundAxis
		{
			get
			{
				return default(RotationAxis);
			}
			set
			{
			}
		}

		public Space relativeTo
		{
			get
			{
				return default(Space);
			}
			set
			{
			}
		}

		public bool reverse
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[CustomObfuscation]
		private void Update()
		{
		}

		private static Vector3 pFajXcJnBAviabKgRKrpIoSHfAMJ(RotationAxis P_0)
		{
			return default(Vector3);
		}

		public void SetSpeed(Speed speed)
		{
		}

		public void SetSpeed(int speed)
		{
		}
	}
}
