using System.Collections.Generic;

namespace Rewired
{
	public struct PlayerSaveData
	{
		private JoystickMapSaveData[] OEJfsNUuTIeuFBuRDCaNuRpxUgZt;

		private KeyboardMapSaveData[] uXllotqyAHIWsQRCshTcigWbMPd;

		private MouseMapSaveData[] MYsrOqZuPpyBAFfCkIkwcriQASF;

		private CustomControllerMapSaveData[] UjtGVqusKclhkzHaSUwoqSCiNKz;

		private InputBehavior[] vRzKeKfOVPvpbXPvQFawHLKwCdF;

		public JoystickMapSaveData[] joystickMapSaveData
		{
			get
			{
				return null;
			}
		}

		public KeyboardMapSaveData[] keyboardMapSaveData
		{
			get
			{
				return null;
			}
		}

		public MouseMapSaveData[] mouseMapSaveData
		{
			get
			{
				return null;
			}
		}

		public CustomControllerMapSaveData[] customControllerMapSaveData
		{
			get
			{
				return null;
			}
		}

		public InputBehavior[] inputBehaviors
		{
			get
			{
				return null;
			}
		}

		public int joystickMapCount
		{
			get
			{
				return default(int);
			}
		}

		public int keyboardMapCount
		{
			get
			{
				return default(int);
			}
		}

		public int mouseMapCount
		{
			get
			{
				return default(int);
			}
		}

		public int customControllerMapCount
		{
			get
			{
				return default(int);
			}
		}

		public int inputBehaviorCount
		{
			get
			{
				return default(int);
			}
		}

		public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData
		{
			get
			{
				return null;
			}
		}

		internal PlayerSaveData(JoystickMapSaveData[] joystickMapSaveData, KeyboardMapSaveData[] keyboardMapSaveData, MouseMapSaveData[] mouseMapSaveData, CustomControllerMapSaveData[] customControllerMapSaveData, IList<InputBehavior> inputBehaviors)
		{
		}
	}
}
