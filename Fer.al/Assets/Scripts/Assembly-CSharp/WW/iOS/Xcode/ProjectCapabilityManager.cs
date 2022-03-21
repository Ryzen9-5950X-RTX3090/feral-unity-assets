namespace WW.iOS.Xcode
{
	public class ProjectCapabilityManager
	{
		private readonly string m_BuildPath;

		private readonly string m_TargetGuid;

		private readonly string m_PBXProjectPath;

		private readonly string m_EntitlementFilePath;

		private PlistDocument m_Entitlements;

		private PlistDocument m_InfoPlist;

		protected internal PBXProject project;

		public ProjectCapabilityManager(string pbxProjectPath, string entitlementFilePath, string targetName)
		{
		}

		public void WriteToFile()
		{
		}

		public void AddiCloud(bool keyValueStorage, bool iCloudDocument, string[] customContainers)
		{
		}

		public void AddPushNotifications(bool development)
		{
		}

		public void AddGameCenter()
		{
		}

		public void AddWallet(string[] passSubset)
		{
		}

		public void AddSiri()
		{
		}

		public void AddApplePay(string[] merchants)
		{
		}

		public void AddInAppPurchase()
		{
		}

		public void AddMaps(MapsOptions options)
		{
		}

		public void AddPersonalVPN()
		{
		}

		public void AddBackgroundModes(BackgroundModesOptions options)
		{
		}

		public void AddKeychainSharing(string[] accessGroups)
		{
		}

		public void AddInterAppAudio()
		{
		}

		public void AddAssociatedDomains(string[] domains)
		{
		}

		public void AddAppGroups(string[] groups)
		{
		}

		public void AddHomeKit()
		{
		}

		public void AddDataProtection()
		{
		}

		public void AddHealthKit()
		{
		}

		public void AddWirelessAccessoryConfiguration()
		{
		}

		private PlistDocument GetOrCreateEntitlementDoc()
		{
			return null;
		}

		private PlistDocument GetOrCreateInfoDoc()
		{
			return null;
		}

		private PlistElementString GetOrCreateStringElementInArray(PlistElementArray root, string value)
		{
			return null;
		}

		private PlistElementDict GetOrCreateUniqueDictElementInArray(PlistElementArray root)
		{
			return null;
		}
	}
}
