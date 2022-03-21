using Rewired.ControllerExtensions;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.PS4
{
	public sealed class PS4GamepadExtension : PS4ControllerExtension, IControllerVibrator, IDualShock4Extension
	{
		private IPS4GamepadExtensionSource Source
		{
			get
			{
				return null;
			}
		}

		public int connectionType
		{
			get
			{
				return default(int);
			}
		}

		public int maxTouches
		{
			get
			{
				return default(int);
			}
		}

		public float touchpadPixelDensity
		{
			get
			{
				return default(float);
			}
		}

		public Vector2 touchpadResolution
		{
			get
			{
				return default(Vector2);
			}
		}

		public int touchpadResolutionX
		{
			get
			{
				return default(int);
			}
		}

		public int touchpadResolutionY
		{
			get
			{
				return default(int);
			}
		}

		public int touchCount
		{
			get
			{
				return default(int);
			}
		}

		internal PS4GamepadExtension(IPS4GamepadExtensionSource source)
		{
		}

		private PS4GamepadExtension(PS4GamepadExtension source)
		{
		}

		public int GetTouchId(int index)
		{
			return default(int);
		}

		public bool GetTouchPosition(int index, out Vector2 position)
		{
			return default(bool);
		}

		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			return default(bool);
		}

		public bool GetTouchPositionAbsolute(int index, out Vector2 position)
		{
			return default(bool);
		}

		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position)
		{
			return default(bool);
		}

		public bool IsTouching(int index)
		{
			return default(bool);
		}

		public bool IsTouchingByTouchId(int touchId)
		{
			return default(bool);
		}

		public float GetVibration(PS4GamepadMotorType motor)
		{
			return default(float);
		}

		public void SetVibration(PS4GamepadMotorType motor, float motorLevel)
		{
		}

		public void SetVibration(PS4GamepadMotorType motor, float motorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(PS4GamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration)
		{
		}

		Vector3 IDualShock4Extension.GetGyroscopeValue()
		{
			return default(Vector3);
		}

		Vector3 IDualShock4Extension.GetGyroscopeValueRaw()
		{
			return default(Vector3);
		}

		internal override Controller.Extension Clone()
		{
			return null;
		}

		private static int ItLhuewpxOtKMQonZrwdQzltTlT(PS4GamepadMotorType P_0)
		{
			return default(int);
		}
	}
}
