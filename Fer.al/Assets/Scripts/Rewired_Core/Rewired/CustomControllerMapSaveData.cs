namespace Rewired
{
	public sealed class CustomControllerMapSaveData : ControllerMapSaveData
	{
		public CustomController customController
		{
			get
			{
				return null;
			}
		}

		public CustomControllerMap customControllerMap
		{
			get
			{
				return null;
			}
		}

		public int customControllerSourceId
		{
			get
			{
				return default(int);
			}
		}

		internal CustomControllerMapSaveData(CustomController customController, CustomControllerMap map)
		{
		}
	}
}
