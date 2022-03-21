using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class CoreGlobalSettingsManager : CoreManagerBase<CoreGlobalSettingsManager>
{
	[Header("Version")]
	public string version;

	[Header("Current Build")]
	public string currentBuild;

	public string currentBuildNumber;

	[Header("Quality")]
	public DeviceQualityLevel quality;

	public bool qualityAutoSetOnDevice;

	[Header("Platform")]
	public bool platformEmulatePhoneInEditor;

	[Header("Audio")]
	public AudioQualityLevel audioQuality;

	[Header("Editor Test Platform")]
	public bool useEditorTestPlatform;

	public EEditorPlatform editorTestPlatform;

	[Header("Localization")]
	public SystemLanguage editorLanguage;

	private static SystemLanguage? _language;

	public bool showUnlocalizedLabels;

	public List<SystemLanguage> supportedLanguages;

	[Header("Debug")]
	public bool showUnityVersionPopup;

	[Header("Charts")]
	public bool chartForceOfflineMode;

	public List<string> chartForceOfflineChartNames;

	public bool chartAllowOfflineMode;

	public bool chartTestOfflineMode;

	[Header("Asset Bundles")]
	public BundleManagerMode bundleMode;

	public SimplePlatform bundlePlatform;

	public bool bundleEmulateSlowBundlesInEditor;

	public bool bundleUseDevBundlesInEditor;

	public bool bundleUseDownloaderInEditor;

	public bool bundleUseEditorAssetBundleServer;

	public string bundleEditorAssetBundleServerURL;

	[Header("Networking")]
	public bool airplaneMode;

	public bool forceKeepAlive;

	public ServerTier serverTier;

	public static ServerTier ServerTier;

	[FormerlySerializedAs("serverEnvironment")]
	public ServerEnvironment currentServerEnvironment;

	public ServerEnvironment[] serverEnvironments;

	private static string _clientID;

	private string _networkChartURL;

	private string _networkAssetBundleURL;

	private string _networkHashedAssetBundleURL;

	public SystemLanguage language
	{
		get
		{
			return default(SystemLanguage);
		}
		set
		{
		}
	}

	public bool IsLanguageReversed
	{
		get
		{
			return default(bool);
		}
	}

	public static string ClientID
	{
		get
		{
			return null;
		}
	}

	public virtual string PostSplashScene
	{
		get
		{
			return null;
		}
	}

	public virtual string DataServerProject
	{
		get
		{
			return null;
		}
	}

	public virtual string ProjectSVNURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string DevBaseURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string ProdBaseURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string StageBaseURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string ProdAlternateBaseURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string StageAlternateBaseURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string DevSharedBaseURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string StageSharedBaseURL
	{
		get
		{
			return null;
		}
	}

	protected virtual string SharedBaseURL
	{
		get
		{
			return null;
		}
	}

	public bool IsProdMode
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsStageMode
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsDevMode
	{
		get
		{
			return default(bool);
		}
	}

	public bool ChartsAndBundlesHashed
	{
		get
		{
			return default(bool);
		}
	}

	public virtual string ProjectDefine
	{
		get
		{
			return null;
		}
	}

	public string GetDevCDNBaseURL()
	{
		return null;
	}

	public string GetStageCDNBaseURL()
	{
		return null;
	}

	public string GetProdCDNBaseURL()
	{
		return null;
	}

	public string GetCDNBaseURL()
	{
		return null;
	}

	public string GetSharedBaseURL()
	{
		return null;
	}

	public string GetNetworkChartURL()
	{
		return null;
	}

	public string GetNetworkAssetBundleURL()
	{
		return null;
	}

	public string GetNetworkHashedAssetBundleURL()
	{
		return null;
	}

	public override void Init()
	{
	}

	public virtual void SetReleaseSettings()
	{
	}

	private void SetSafeSettingsForCurrentPlatform()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public ServerEnvironment GetServerEnvironmentByName(string name)
	{
		return null;
	}

	public void SetServerEnvironmentByName(string name)
	{
	}
}
