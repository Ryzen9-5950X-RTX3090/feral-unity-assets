using System;

namespace Rewired
{
	public sealed class JoystickCalibrationMapSaveData : CalibrationMapSaveData
	{
		private Guid omUEjyqgwycEFtqhXRmkZDDttRN;

		public Guid joystickHardwareTypeGuid
		{
			get
			{
				return default(Guid);
			}
		}

		public JoystickCalibrationMapSaveData(CalibrationMap calibrationMap, ControllerType controllerType, string hardwareIdentifier, Guid joystickHardwareTypeGuid)
		{
		}
	}
}
