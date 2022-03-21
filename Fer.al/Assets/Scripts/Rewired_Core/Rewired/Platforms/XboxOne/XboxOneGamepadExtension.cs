using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

namespace Rewired.Platforms.XboxOne
{
	public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator
	{
		private class EqnErQJtoXnBimhhcZEPviHzgJU : IControllerExtensionSource
		{
			public const int zGdbUshTycKAtYCpVcJXKunoKXo = 4;

			public xcWyiIfNoFqFVFpAfvXHnUTXXPi NZEeeCgWyRqoyvxRZxYoteYRyHmo;

			public readonly IXboxOneInputSource fdFATyDPtIlZRSsXTKMYVilUDtz;

			public readonly bool kSrtaAGsebkQowBSfdkRuELNUCR;

			public EqnErQJtoXnBimhhcZEPviHzgJU(bool supportsVibration, IXboxOneInputSource xboxOneInputSource, xcWyiIfNoFqFVFpAfvXHnUTXXPi vibrationData)
			{
			}
		}

		private EqnErQJtoXnBimhhcZEPviHzgJU EWvxEcokoAEStdCudJqOMgkHwwyD;

		private TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj;

		private Joystick joystick
		{
			get
			{
				return null;
			}
		}

		public int xboxOneUserId
		{
			get
			{
				return default(int);
			}
		}

		public ulong xboxOneJoystickId
		{
			get
			{
				return default(ulong);
			}
		}

		public int vibrationMotorCount
		{
			get
			{
				return default(int);
			}
		}

		internal XboxOneGamepadExtension(bool supportsVibration, IXboxOneInputSource xboxOneInputSource)
		{
		}

		private XboxOneGamepadExtension(XboxOneGamepadExtension source)
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

		public float GetVibration(XboxOneGamepadMotorType motor)
		{
			return default(float);
		}

		public void StopVibration()
		{
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel)
		{
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration)
		{
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel)
		{
		}

		public void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration)
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

		private void NkodnkKMvxPXugZCqkaWDsqVwYA(XboxOneGamepadMotorType P_0, float P_1, float P_2)
		{
		}

		private void FcTHFOwfYFXyJYzmCrbOHLnKiFX()
		{
		}
	}
}
