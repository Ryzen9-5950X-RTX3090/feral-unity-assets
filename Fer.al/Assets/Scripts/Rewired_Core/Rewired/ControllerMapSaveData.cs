using System;

namespace Rewired
{
	public abstract class ControllerMapSaveData
	{
		protected Controller _controller;

		protected ControllerMap _map;

		internal readonly int vSShldFHkaZKEuThltrSgFmPfc;

		public ControllerMap map
		{
			get
			{
				return null;
			}
		}

		public int categoryId
		{
			get
			{
				return default(int);
			}
		}

		public int layoutId
		{
			get
			{
				return default(int);
			}
		}

		public Type mapType
		{
			get
			{
				return null;
			}
		}

		public string mapTypeString
		{
			get
			{
				return null;
			}
		}

		public Controller controller
		{
			get
			{
				return null;
			}
		}

		public ControllerType controllerType
		{
			get
			{
				return default(ControllerType);
			}
		}

		public string controllerHardwareIdentifier
		{
			get
			{
				return null;
			}
		}

		public T GetMap<T>() where T : ControllerMap
		{
			return null;
		}

		internal ControllerMapSaveData(Controller controller, ControllerMap map)
		{
		}

		internal static T AQMpZVIIXTyemnHtIDPtxhINdLN<T>(Controller P_0, ControllerMap P_1) where T : ControllerMapSaveData
		{
			return null;
		}

		internal static ControllerMapSaveData AQMpZVIIXTyemnHtIDPtxhINdLN(Controller P_0, ControllerMap P_1)
		{
			return null;
		}
	}
}
