namespace VivoxUnity
{
	public class VivoxDebug
	{
		private static VivoxDebug _instance;

		public int debugLocation;

		public bool throwInternalExcepetions;

		public static VivoxDebug Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void VxExceptionMessage(string message)
		{
		}

		public virtual void DebugMessage(object message, vx_log_level severity = vx_log_level.log_debug)
		{
		}
	}
}
