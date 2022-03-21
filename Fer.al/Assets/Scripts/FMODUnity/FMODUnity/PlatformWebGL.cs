namespace FMODUnity
{
	public class PlatformWebGL : Platform
	{
		public override string DisplayName
		{
			get
			{
				return null;
			}
		}

		static PlatformWebGL()
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
