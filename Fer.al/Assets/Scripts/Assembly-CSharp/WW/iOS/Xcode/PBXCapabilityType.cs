namespace WW.iOS.Xcode
{
	public sealed class PBXCapabilityType
	{
		public struct TargetCapabilityPair
		{
			public string targetGuid;

			public PBXCapabilityType capability;

			public TargetCapabilityPair(string guid, PBXCapabilityType type)
			{
			}
		}

		public static readonly PBXCapabilityType ApplePay;

		public static readonly PBXCapabilityType AppGroups;

		public static readonly PBXCapabilityType AssociatedDomains;

		public static readonly PBXCapabilityType BackgroundModes;

		public static readonly PBXCapabilityType DataProtection;

		public static readonly PBXCapabilityType GameCenter;

		public static readonly PBXCapabilityType HealthKit;

		public static readonly PBXCapabilityType HomeKit;

		public static readonly PBXCapabilityType iCloud;

		public static readonly PBXCapabilityType InAppPurchase;

		public static readonly PBXCapabilityType InterAppAudio;

		public static readonly PBXCapabilityType KeychainSharing;

		public static readonly PBXCapabilityType Maps;

		public static readonly PBXCapabilityType PersonalVPN;

		public static readonly PBXCapabilityType PushNotifications;

		public static readonly PBXCapabilityType Siri;

		public static readonly PBXCapabilityType Wallet;

		public static readonly PBXCapabilityType WirelessAccessoryConfiguration;

		private readonly string m_ID;

		private readonly bool m_RequiresEntitlements;

		private readonly string m_Framework;

		private readonly bool m_OptionalFramework;

		public bool optionalFramework
		{
			get
			{
				return default(bool);
			}
		}

		public string framework
		{
			get
			{
				return null;
			}
		}

		public string id
		{
			get
			{
				return null;
			}
		}

		public bool requiresEntitlements
		{
			get
			{
				return default(bool);
			}
		}

		private PBXCapabilityType(string _id, bool _requiresEntitlements, string _framework = "", bool _optionalFramework = false)
		{
		}

		public static PBXCapabilityType StringToPBXCapabilityType(string cap)
		{
			return null;
		}
	}
}
