using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using SQLite4Unity3d;
using UnityEngine;

public class CoreChartDataManager : CoreManagerBase<CoreChartDataManager>
{
	public class DBSqlTableEntry
	{
		public string defId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string template
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}

	public class DBEntry
	{
		private SQLiteConnection _connection;

		private bool? _isDBFileEncrypted;

		public string currentHash;

		public string previousHash;

		private double editorLastHashTime;

		public ChartDataObject parentChartDataObject;

		public SQLiteConnection Connection
		{
			get
			{
				return null;
			}
		}

		public bool IsDBFileEncrypted
		{
			get
			{
				return default(bool);
			}
		}

		public bool HashChanged
		{
			get
			{
				return default(bool);
			}
		}

		public bool HashIsValid
		{
			get
			{
				return default(bool);
			}
		}

		public bool HashIsReset
		{
			get
			{
				return default(bool);
			}
		}

		public string DBFileCachedTempPath
		{
			get
			{
				return null;
			}
		}

		public string DBFileCachedPath
		{
			get
			{
				return null;
			}
		}

		public string DBFileCachedFilename
		{
			get
			{
				return null;
			}
		}

		public string DBFileCachedTempFilename
		{
			get
			{
				return null;
			}
		}

		public bool IsDBFileCached
		{
			get
			{
				return default(bool);
			}
		}

		public string DBFileURL
		{
			get
			{
				return null;
			}
		}

		public string HashFileURL
		{
			get
			{
				return null;
			}
		}

		public string CachedHashKey
		{
			get
			{
				return null;
			}
		}

		public string CachedHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsDBFileCorrupt
		{
			get
			{
				return default(bool);
			}
		}

		public void CloseConnection()
		{
		}

		public void ClearCachedDBFile()
		{
		}

		[IteratorStateMachine(typeof(<DownloadCurrentHashAndSetIt>d__37))]
		public IEnumerator DownloadCurrentHashAndSetIt(bool inCheckForResetHash = false)
		{
			return null;
		}

		public bool EditorDownloadCurrentHashAndSetIt()
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<DownloadDBFileAndCacheIt>d__41))]
		public IEnumerator DownloadDBFileAndCacheIt(int inRetryDBConnectCount = 0)
		{
			return null;
		}

		private void DownloadDBFileAndCacheItRetry(int inRetryDBConnectCount)
		{
		}

		public void EditorDownloadDBFileAndCacheIt()
		{
		}
	}

	public ManifestChartData manifestChartData;

	public GlobalChartData globalChartData;

	public DebugChartData debugChartData;

	public URLChartData urlChartData;

	public AnalyticsChartData analyticsChartData;

	public SystemLocalizationChartData systemLocalizationChartData;

	public LocalizationChartData localizationChartData;

	public ListChartData listChartData;

	public LevelOverrideChartData levelOverrideChartData;

	public LevelChartData levelChartData;

	public ImageChartData imageChartData;

	private FieldInfo[] _fields;

	private static bool _isDownloading;

	private Dictionary<string, DBEntry> _dbEntries;

	private static string _chartCacheFolderPath;

	private static bool _offlineMode;

	private static Dictionary<Type, MethodInfo> _cachedGetDefsMethods;

	private static Dictionary<Type, MethodInfo> _cachedGetDefMethods;

	public FieldInfo[] Fields
	{
		get
		{
			return null;
		}
	}

	public IEnumerable<ChartDataObject> ChartDataObjects
	{
		[IteratorStateMachine(typeof(<get_ChartDataObjects>d__16))]
		get
		{
			return null;
		}
	}

	public static bool IsDownloading
	{
		get
		{
			return default(bool);
		}
	}

	public Dictionary<string, DBEntry> DBEntries
	{
		get
		{
			return null;
		}
	}

	public static string ChartCacheFolderPath
	{
		get
		{
			return null;
		}
	}

	public static bool OfflineMode
	{
		get
		{
			return default(bool);
		}
	}

	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}

	public void ClearAllCharts()
	{
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__22))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	public override void Deinit()
	{
	}

	public static void ClearCachedCharts()
	{
	}

	private string GetDatabaseHashURLForDatabaseName(string inDBName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetCurrentHashesAndDownloadDBsIfNeeded>d__37))]
	public IEnumerator GetCurrentHashesAndDownloadDBsIfNeeded(bool inInitialCall, bool inCheckForResetHash = false)
	{
		return null;
	}

	public static bool EditorGetCurrentHashesAndDownloadDBsIfNeeded()
	{
		return default(bool);
	}

	public void SetChartObjectInstances()
	{
	}

	public static bool ExtractZipFile(string inPath, string inPassword, string inOutPath)
	{
		return default(bool);
	}

	public static bool ExtractTarFile(string inPath, string inOutPath)
	{
		return default(bool);
	}

	public BundledDef GenericGetBundledDefWithDefID(string inChartName, string inDefID)
	{
		return null;
	}

	public static T GenericGetDefWithDefID<T>(string inChartName, string inDefID) where T : BaseDef
	{
		return null;
	}

	public static List<T> GenericGetDefsWithDefIDs<T>(string inChartName, List<string> inDefIDs) where T : BaseDef
	{
		return null;
	}

	public static List<T> GenericGetDefsWithDefIDs<T>(Type inChartType, List<string> inDefIDs) where T : BaseDef
	{
		return null;
	}

	public static T GenericGetDefWithDefID<T>(Type inChartType, string inDefID) where T : BaseDef
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
