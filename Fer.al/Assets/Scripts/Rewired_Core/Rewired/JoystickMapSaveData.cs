using System;

namespace Rewired
{
	public sealed class JoystickMapSaveData : ControllerMapSaveData
	{
		public Joystick joystick
		{
			get
			{
				return null;
			}
		}

		public JoystickMap joystickMap
		{
			get
			{
				return null;
			}
		}

		public Guid joystickHardwareTypeGuid
		{
			get
			{
				return default(Guid);
			}
		}

		internal JoystickMapSaveData(Joystick joystick, JoystickMap map)
		{
		}
	}
}
