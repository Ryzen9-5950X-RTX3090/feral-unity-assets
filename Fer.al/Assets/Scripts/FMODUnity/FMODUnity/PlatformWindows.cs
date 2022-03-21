namespace FMODUnity
{
	public class PlatformWindows : Platform
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		static PlatformWindows()
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
