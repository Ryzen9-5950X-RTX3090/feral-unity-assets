namespace FMODUnity
{
	public class PlatformLinux : Platform
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		static PlatformLinux()
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
