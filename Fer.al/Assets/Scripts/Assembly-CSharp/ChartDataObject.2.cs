using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SQLite4Unity3d;
using UnityEngine;

public class ChartDataObject<T, U> : ChartDataObject where T : BaseDef, new()where U : ChartDataObject<T, U>
{
	public class DefListSort : IComparer<T>
	{
		public int Compare(T x, T y)
		{
			return default(int);
		}
	}

	[ReloadCSV]
	public bool editorStubReloadButtons;

	[HideInInspector]
	public string editorSearchString;

	[SearchCSV]
	public bool editorStubSearchableDefList;

	private List<string> _defHeaderNames;

	private Dictionary<string, T> _parsedDefsByID;

	private HashSet<string> _notFoundDefIDs;

	private List<T> _defList;

	[SetInstance]
	protected static U _instance;

	private bool? _isManifest;

	[NonSerialized]
	private bool _isForcedReloaded;

	[NonSerialized]
	public bool _isReloaded;

	[NonSerialized]
	public bool isDownloading;

	[NonSerialized]
	public bool isSuccess;

	[NonSerialized]
	private string _thisChartName;

	private List<string> _tokens;

	private Coroutine _cleanupRoutine;

	public List<T> defList
	{
		get
		{
			return null;
		}
	}

	public static U instance
	{
		get
		{
			return null;
		}
	}

	public bool IsManifest
	{
		get
		{
			return default(bool);
		}
	}

	public bool isReloaded
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual string BundleRoot
	{
		get
		{
			return null;
		}
	}

	public override string ChartName
	{
		get
		{
			return null;
		}
	}

	private string DebugVerboseName
	{
		get
		{
			return null;
		}
	}

	public CoreChartDataManager.DBEntry DBEntry
	{
		get
		{
			return null;
		}
	}

	public SQLiteConnection DBConnection
	{
		get
		{
			return null;
		}
	}

	public void ForceLoadAllDefs()
	{
	}

	public void SetInstance()
	{
	}

	public void UnsetInstance()
	{
	}

	public void LazyReload()
	{
	}

	public override BaseDef GetDef(string inDefID, bool inShowErrors = false)
	{
		return null;
	}

	public static void EditorDownloadAndReloadCSVChart()
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public void Log(string inLog)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public void LogError(string inLog)
	{
	}

	public void ClearParsedDefs()
	{
	}

	public void ReloadChart()
	{
	}

	public virtual void WriteCSVChart()
	{
	}

	public void WriteDefines()
	{
	}

	public static T GetRandomDef()
	{
		return null;
	}

	public static bool HasDefWithDefID(string inDefID)
	{
		return default(bool);
	}

	public static T GetDefWithDefID(string inDefID, bool inShowErrors = true)
	{
		return null;
	}

	private static string XorEncryptOrDecrypt(string inText, string inKey)
	{
		return null;
	}

	private static string XorDecrypt(bool inUseEncryption, string inBase64Text, string inKey)
	{
		return null;
	}

	private static string XorEncrypt(bool inUseEncryption, string inText, string inKey)
	{
		return null;
	}

	public string QueryDataWithDefID(string inDefID)
	{
		return null;
	}

	private void ParseData(string inData)
	{
	}

	public override List<ValueTuple<string, string>> GetAllDefIDs()
	{
		return null;
	}

	[IteratorStateMachine(typeof(ChartDataObject<, >.<CleanupOldDefIDs>d__57))]
	private IEnumerator CleanupOldDefIDs()
	{
		return null;
	}

	public List<T> InstanceGetDefsWithDefIDs(List<string> inDefIDs, bool inShowErrors = true)
	{
		return null;
	}

	public static List<T> GetDefsWithDefIDs(List<string> inDefIDs, bool inShowErrors = true)
	{
		return null;
	}

	public static T GetDefWithDefName(string inDefName, bool inShowErrors = true)
	{
		return null;
	}

	public static T EditorGetDefWithDefID(string inDefID, bool inShowErrors = true)
	{
		return null;
	}

	public static T EditorGetDefWithDefName(string inDefName, bool inShowErrors = true)
	{
		return null;
	}

	public void AddDef(T inDef)
	{
	}

	public List<string> EditorGetDefNames()
	{
		return null;
	}

	public List<string> EditorGetDefIDs()
	{
		return null;
	}

	public static List<CoreChartDataManager.DBSqlTableEntry> GetAllDefEntries()
	{
		return null;
	}

	public static List<string> GetDefIDs()
	{
		return null;
	}

	public static List<string> GetDefNames()
	{
		return null;
	}

	public virtual void EditorDrawDef(string inDefID, Rect inRect)
	{
	}

	public string GetRootBundlePath()
	{
		return null;
	}

	protected virtual T CreateDef(Dictionary<string, string> inHeaderNameToDataDict)
	{
		return null;
	}

	public static TC GetDefComponentWithDefName<TC>(string inDefID) where TC : DefComponent
	{
		return null;
	}

	public static TC GetDefComponentWithDefID<TC>(string inDefID, bool inShowErrors = true) where TC : DefComponent
	{
		return null;
	}

	public static List<TC> GetDefComponentsWithDefIDs<TC>(List<string> inDefIDs, bool inShowErrors = true) where TC : DefComponent
	{
		return null;
	}
}
