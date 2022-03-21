using Amazon.Util.Storage;

namespace Amazon.Util.Internal.PlatformServices
{
	public class ApplicationSettings : IApplicationSettings
	{
		private KVStore kvStore;

		public void SetValue(string key, string value, ApplicationSettingsMode mode)
		{
		}

		public string GetValue(string key, ApplicationSettingsMode mode)
		{
			return null;
		}

		public void RemoveValue(string key, ApplicationSettingsMode mode)
		{
		}
	}
}
