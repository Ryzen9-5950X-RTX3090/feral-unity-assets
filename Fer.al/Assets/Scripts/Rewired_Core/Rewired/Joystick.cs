using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

namespace Rewired
{
	public class Joystick : ControllerWithAxes
	{
		private const int LEFT_MOTOR_INDEX = 0;

		private const int RIGHT_MOTOR_INDEX = 1;

		private IInputManagerJoystickPublic _sourceJoystick;

		private readonly JoystickType[] _joystickTypes;

		private readonly ReadOnlyCollection<JoystickType> _joystickTypes_readOnly;

		private readonly bool _supportsVibration;

		private readonly bool _supportsLocalVibration;

		private readonly bool _supportsVoice;

		private readonly int _localVibrationMotorCount;

		private readonly float[] _localVibrationMotorValues;

		private readonly TimerAbs[] _localVibrationStopTimers;

		private readonly int _hatCount;

		private readonly Hat[] _hats;

		private readonly ReadOnlyCollection<Hat> hats_readOnly;

		internal IList<JoystickType> joystickTypes
		{
			get
			{
				return null;
			}
		}

		public long? systemId
		{
			get
			{
				return null;
			}
		}

		public int unityId
		{
			get
			{
				return default(int);
			}
		}

		public override Guid deviceInstanceGuid
		{
			get
			{
				return default(Guid);
			}
		}

		public bool supportsVibration
		{
			get
			{
				return default(bool);
			}
		}

		public float vibrationLeftMotor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float vibrationRightMotor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int vibrationMotorCount
		{
			get
			{
				return default(int);
			}
		}

		public int hatCount
		{
			get
			{
				return default(int);
			}
		}

		public IList<Hat> Hats
		{
			get
			{
				return null;
			}
		}

		internal int inputManagerId
		{
			get
			{
				return default(int);
			}
		}

		internal HardwareControllerMapIdentifier hardwareJoystickMapIdentifier
		{
			get
			{
				return default(HardwareControllerMapIdentifier);
			}
		}

		internal Joystick(BridgedController controller)
		{
		}

		private Joystick(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
		{
		}

		internal bool IsType(JoystickType joystickType)
		{
			return default(bool);
		}

		public JoystickCalibrationMapSaveData GetCalibrationMapSaveData()
		{
			return null;
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration)
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

		internal override void UpdateData(UpdateLoopType updateLoop)
		{
		}

		internal void UpdateControllerInfo(UpdateControllerInfoEventArgs args)
		{
		}

		internal void UpdateControllerInfo(BridgedController controller)
		{
		}

		private void UpdateControllerInfo(IInputManagerJoystickPublic joystick)
		{
		}

		internal override void Clear()
		{
		}

		protected override void Disconnected()
		{
		}

		private void CheckVibrationTimeout()
		{
		}

		private void SetLocalVibration(int motorIndex, float motorLevel, float motorDuration, bool stopOtherMotors, bool updateNow)
		{
		}

		private void UpdateLocalControllerVibration()
		{
		}

		private void StopAllVibration()
		{
		}

		internal static int CompareById_Ascending(Joystick a, Joystick b)
		{
			return default(int);
		}
	}
}
