namespace UnityEngine.UI
{
	public static class WWUISetPropertyUtility
	{
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
		}
	}
}
