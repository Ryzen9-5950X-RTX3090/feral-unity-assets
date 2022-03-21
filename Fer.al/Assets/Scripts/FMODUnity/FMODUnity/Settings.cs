using System;
using System.Collections.Generic;
using FMOD;
using UnityEngine;

namespace FMODUnity
{
	public class Settings : ScriptableObject
	{
		private struct PlatformTemplate
		{
			public string Identifier;

			public Func<Platform> CreateInstance;
		}

		[SerializeField]
		public List<WWBuildPlatforms> buildPlatforms;

		private const string SettingsAssetName = "FMODStudioSettings";

		private static Settings instance;

		private static bool isInitializing;

		[SerializeField]
		public bool HasSourceProject;

		[SerializeField]
		public bool HasPlatforms;

		[SerializeField]
		private string sourceProjectPath;

		[SerializeField]
		private string sourceBankPath;

		[SerializeField]
		public string SourceBankPathUnformatted;

		[SerializeField]
		public bool AutomaticEventLoading;

		[SerializeField]
		public BankLoadType BankLoadType;

		[SerializeField]
		public bool AutomaticSampleLoading;

		[SerializeField]
		public string EncryptionKey;

		[SerializeField]
		public ImportType ImportType;

		[SerializeField]
		public string TargetAssetPath;

		[SerializeField]
		public string TargetBankFolder;

		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[SerializeField]
		public List<Legacy.PlatformIntSetting> SpeakerModeSettings;

		[SerializeField]
		public List<Legacy.PlatformIntSetting> SampleRateSettings;

		[SerializeField]
		public List<Legacy.PlatformBoolSetting> LiveUpdateSettings;

		[SerializeField]
		public List<Legacy.PlatformBoolSetting> OverlaySettings;

		[SerializeField]
		public List<Legacy.PlatformBoolSetting> LoggingSettings;

		[SerializeField]
		public List<Legacy.PlatformStringSetting> BankDirectorySettings;

		[SerializeField]
		public List<Legacy.PlatformIntSetting> VirtualChannelSettings;

		[SerializeField]
		public List<Legacy.PlatformIntSetting> RealChannelSettings;

		[SerializeField]
		public List<string> Plugins;

		[SerializeField]
		public List<string> MasterBanks;

		[SerializeField]
		public List<string> Banks;

		[SerializeField]
		public List<string> BanksToLoad;

		[SerializeField]
		public ushort LiveUpdatePort;

		[SerializeField]
		public bool EnableMemoryTracking;

		[SerializeField]
		public bool AndroidUseOBB;

		[SerializeField]
		public MeterChannelOrderingType MeterChannelOrdering;

		[SerializeField]
		public bool StopEventsOutsideMaxDistance;

		[SerializeField]
		public bool BoltUnitOptionsBuildPending;

		private Dictionary<string, Platform> Platforms;

		private Dictionary<RuntimePlatform, List<Platform>> PlatformForRuntimePlatform;

		[NonSerialized]
		private Platform defaultPlatform;

		[NonSerialized]
		private Platform playInEditorPlatform;

		private static List<PlatformTemplate> platformTemplates;

		public static Settings Instance
		{
			get
			{
				return null;
			}
		}

		public string SourceProjectPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SourceBankPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TargetPath
		{
			get
			{
				return null;
			}
		}

		public string TargetSubFolder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Platform DefaultPlatform
		{
			get
			{
				return null;
			}
		}

		public Platform PlayInEditorPlatform
		{
			get
			{
				return null;
			}
		}

		public Platform FindPlatform(string identifier)
		{
			return null;
		}

		public void ForEachPlatform(Action<Platform> action)
		{
		}

		private void LinkPlatform(Platform platform)
		{
		}

		public void DeclareRuntimePlatform(RuntimePlatform runtimePlatform, Platform platform)
		{
		}

		private void LinkPlatformToParent(Platform platform)
		{
		}

		public Platform FindCurrentPlatform()
		{
			return null;
		}

		public SPEAKERMODE GetEditorSpeakerMode()
		{
			return default(SPEAKERMODE);
		}

		private Settings()
		{
		}

		public void AddPlatformProperties(Platform platform)
		{
		}

		public static void AddPlatformTemplate<T>(string identifier) where T : Platform
		{
		}

		private static Platform CreatePlatformInstance<T>(string identifier) where T : Platform
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void PopulatePlatformsFromAsset()
		{
		}
	}
}
