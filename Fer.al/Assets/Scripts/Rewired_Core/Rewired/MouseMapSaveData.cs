namespace Rewired
{
	public sealed class MouseMapSaveData : ControllerMapSaveData
	{
		public MouseMap keyboardMap
		{
			get
			{
				return null;
			}
		}

		internal MouseMapSaveData(Mouse mouse, MouseMap map)
		{
		}
	}
}
