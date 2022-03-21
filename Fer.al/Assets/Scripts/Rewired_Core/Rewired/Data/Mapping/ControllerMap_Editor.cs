using System;
using System.Collections.Generic;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ControllerMap_Editor
	{
		public int id;

		public int categoryId;

		public int layoutId;

		public string name;

		public string hardwareGuidString;

		public int customControllerUid;

		public List<ActionElementMap> actionElementMaps;

		public IEnumerable<ActionElementMap> ActionElementMaps
		{
			get
			{
				return null;
			}
		}

		public Guid hardwareGuid
		{
			get
			{
				return default(Guid);
			}
		}

		public ControllerMap_Editor Clone()
		{
			return null;
		}

		public ActionElementMap GetActionElementMap(int index)
		{
			return null;
		}

		internal JoystickMap TNRoDaxnweWTmUCmpdXMNeyhAsE(Func<int, bool> P_0, HardwareControllerMapIdentifier P_1, HardwareJoystickMap P_2, bool P_3)
		{
			return null;
		}

		internal KeyboardMap CObfGdbXviCUNBOxWfcmfKizwYH(Func<int, bool> P_0)
		{
			return null;
		}

		internal MouseMap FDzGmdqWxkfkEbdcGRorwAkaokJ(Func<int, bool> P_0)
		{
			return null;
		}

		internal CustomControllerMap pyoiHlRQNeNOPQeHDIZDlcktqVI(Func<int, bool> P_0, CustomController_Editor P_1)
		{
			return null;
		}

		internal ControllerTemplateMap WVBGGcAShyAhuaoJOBlxFvkqAyeX()
		{
			return null;
		}

		private void VjRfFCOOvZcaIkFFirwEbuTrteB(Func<int, bool> P_0, ControllerMap P_1, HardwareControllerMapIdentifier P_2, HardwareJoystickMap P_3, bool P_4)
		{
		}

		private void GFqNidtcClgZNeDxxaISdzmTkQyY(Func<int, bool> P_0, InputSource P_1, CustomControllerMap P_2, CustomController_Editor P_3)
		{
		}

		public void CreateElementsFromHardwareMap(IHardwareControllerMap hardwareJoystickMap)
		{
		}

		public void CreateElementsFromHardwareMap(CustomController_Editor customController)
		{
		}

		public void AddActionElementMap()
		{
		}

		public void InsertActionElementMap(int index)
		{
		}

		public void DeleteActionElementMap(int index)
		{
		}

		public bool ReorderActionElementMap(int index, bool offsetDown, bool offsetNow)
		{
			return default(bool);
		}

		public void DuplicateActionElementMap(int index)
		{
		}

		private ActionElementMap saoLdySNTnPBmokzuXxVdBgfdPe()
		{
			return null;
		}
	}
}
