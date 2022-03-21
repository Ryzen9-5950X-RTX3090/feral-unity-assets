namespace FMODUnity
{
	public class PlatformMac : Platform
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		static PlatformMac()
		{
		}

		public override void DeclareUnityMappings(Settings settings)
		{
		}

		public override string GetPluginPath(string pluginName)
		{
			return null;
		}
	}
}
