using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	public sealed class DualShock4Extension : Controller.Extension, IControllerVibrator, IDualShock4Extension
	{
		private class CCARidKdkHWupJlanLcBYGeGRlz : IControllerExtensionSource
		{
			public readonly IDriver_DualShock4 pLSlGvFkDOedcZzLNmTZIETLroL;

			public readonly bool kSrtaAGsebkQowBSfdkRuELNUCR;

			public readonly int zGdbUshTycKAtYCpVcJXKunoKXo;

			public CCARidKdkHWupJlanLcBYGeGRlz(IDriver_DualShock4 driver, bool supportsVibration, int vibrationMotorCount)
			{
			}
		}

		private CCARidKdkHWupJlanLcBYGeGRlz JEVAvDAWidJhVxFUpAPvixPZmfz;

		private bool fgNnLmrmmahxmiDfYojqjhBnGlga;

		private TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj;

		private Joystick joystick
		{
			get
			{
				return null;
			}
		}

		public int vibrationMotorCount
		{
			get
			{
				return default(int);
			}
		}

		public float lightColorRed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float lightColorGreen
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float lightColorBlue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int maxTouches
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

		public float batteryLevel
		{
			get
			{
				return default(float);
			}
		}

		internal DualShock4Extension(IDriver_DualShock4 driver)
		{
		}

		private DualShock4Extension(DualShock4Extension source)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public float GetVibration(int motorIndex)
		{
			return default(float);
		}

		public void StopVibration()
		{
		}

		public float GetVibration(DualShock4MotorType motor)
		{
			return default(float);
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel)
		{
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration)
		{
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration)
		{
		}

		public Color GetLightColor()
		{
			return default(Color);
		}

		public void SetLightColor(Color color)
		{
		}

		public void SetLightColor(float red, float green, float blue)
		{
		}

		public void SetLightColor(float red, float green, float blue, float intensity)
		{
		}

		public void SetLightFlash(float onDuration, float offDuration)
		{
		}

		public void StopLightFlash()
		{
		}

		public Vector3 GetAccelerometerValueRaw()
		{
			return default(Vector3);
		}

		public Vector3 GetAccelerometerValue()
		{
			return default(Vector3);
		}

		public Vector3 GetLastGyroscopeValueRaw()
		{
			return default(Vector3);
		}

		public Vector3 GetLastGyroscopeValue()
		{
			return default(Vector3);
		}

		public Vector3 GetGyroscopeValueRaw()
		{
			return default(Vector3);
		}

		public Vector3 GetGyroscopeValue()
		{
			return default(Vector3);
		}

		public Quaternion GetOrientation()
		{
			return default(Quaternion);
		}

		public void ResetOrientation()
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

		Vector3 IDualShock4Extension.GetGyroscopeValue()
		{
			return default(Vector3);
		}

		Vector3 IDualShock4Extension.GetGyroscopeValueRaw()
		{
			return default(Vector3);
		}

		internal override void UpdateData(UpdateLoopType P_0)
		{
		}

		internal override void SourceUpdated(IControllerExtensionSource P_0)
		{
		}

		internal override Controller.Extension Clone()
		{
			return null;
		}

		private void mWMaDNGJIyzNYllidjlJnePaxMDR()
		{
		}

		private void NkodnkKMvxPXugZCqkaWDsqVwYA(DualShock4MotorType P_0, float P_1, float P_2)
		{
		}
	}
}
