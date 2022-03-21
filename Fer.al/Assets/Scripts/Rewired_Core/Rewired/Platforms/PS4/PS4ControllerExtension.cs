using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired.Platforms.PS4
{
	public class PS4ControllerExtension : Controller.Extension, IControllerVibrator
	{
		internal class OYaRfyZvtooqbDymOVKnJBtChvU : IControllerExtensionSource
		{
			public readonly IPS4ControllerExtensionSource EWvxEcokoAEStdCudJqOMgkHwwyD;

			public OYaRfyZvtooqbDymOVKnJBtChvU(IPS4ControllerExtensionSource source)
			{
			}
		}

		private readonly TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj;

		private IPS4ControllerExtensionSource Source
		{
			get
			{
				return null;
			}
		}

		internal Joystick joystick
		{
			get
			{
				return null;
			}
		}

		public int userStatusCode
		{
			get
			{
				return default(int);
			}
		}

		public bool userIsPrimary
		{
			get
			{
				return default(bool);
			}
		}

		public int userId
		{
			get
			{
				return default(int);
			}
		}

		public Color userColor
		{
			get
			{
				return default(Color);
			}
		}

		public int userColorId
		{
			get
			{
				return default(int);
			}
		}

		public string userName
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

		internal PS4ControllerExtension(IPS4ControllerExtensionSource source)
		{
		}

		protected PS4ControllerExtension(PS4ControllerExtension source)
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

		public Quaternion GetOrientationRaw()
		{
			return default(Quaternion);
		}

		public Quaternion GetOrientation()
		{
			return default(Quaternion);
		}

		public void ResetOrientation()
		{
		}

		public void SetMotionSensorState(bool enabled)
		{
		}

		public void SetTiltCorrectionState(bool enabled)
		{
		}

		public void SetAngularVelocityDeadbandState(bool enabled)
		{
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

		public void ResetLight()
		{
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

		private void NkodnkKMvxPXugZCqkaWDsqVwYA(int P_0, float P_1, float P_2)
		{
		}
	}
}
