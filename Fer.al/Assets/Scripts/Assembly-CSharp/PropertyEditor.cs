using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using LitJson;
using Microsoft.Extensions.ObjectPool;
using UnityEngine;

public class PropertyEditor
{
	public class Chart
	{
		public Project parentProject;

		public long dtStamp;

		public string name;

		public string label;

		public bool commitable;

		private List<DefEntry> _defEntries;

		public Dictionary<string, DefEntry> defEntryDict;

		private bool _lastIsDirty;

		private double _lastIsDirtyCheckFrame;

		public List<DefEntry> defEntries
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsRefreshing
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsDirty
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsDirtyAndAllowCommit
		{
			get
			{
				return default(bool);
			}
		}

		public Chart(Project inParentProject)
		{
		}

		public DefEntry GetDefEntryWithDefName(string inName)
		{
			return null;
		}

		public DefEntry GetDefEntry(string inID)
		{
			return null;
		}

		public void RevertAll()
		{
		}

		public void Commit(string inComment, bool inCommitFormatChanges, [Optional] List<DefEntry> inOverrideEntries)
		{
		}

		[IteratorStateMachine(typeof(<CommitRoutine>d__25))]
		public IEnumerator CommitRoutine(string inComment, bool inCommitFormatChanges = false, [Optional] List<DefEntry> inOverrideEntries)
		{
			return null;
		}

		public void CreateNew(string inDefName, [Optional] string inTemplateClass, [Optional] string inDataJSON, [Optional] Dictionary<string, JsonData> inColumnData, [Optional] Action<DefEntry> inNewDefEntryCallback)
		{
		}

		[IteratorStateMachine(typeof(<CreateNewRoutine>d__27))]
		public IEnumerator CreateNewRoutine(string inDefName, [Optional] string inTemplateClass, [Optional] string inDataJSON, [Optional] Dictionary<string, JsonData> inColumnData, [Optional] Action<DefEntry> inNewDefEntryCallback)
		{
			return null;
		}

		public void Delete(List<DefEntry> inDelete)
		{
		}

		[IteratorStateMachine(typeof(<DeleteRoutine>d__29))]
		public IEnumerator DeleteRoutine(List<DefEntry> inDelete)
		{
			return null;
		}

		public string ExportAsJSON()
		{
			return null;
		}

		public string ExportAsCSV()
		{
			return null;
		}

		public void ImportAsJSON(string inJSON)
		{
		}

		public void ImportAsCSV(string inCSV)
		{
		}

		private ValueTuple<List<string>, List<string>> ParseCSVHeadersAndLines(string inCSV)
		{
			return default(ValueTuple<List<string>, List<string>>);
		}

		private Dictionary<string, string> ParseCSVLine(List<string> inHeaders, string inCSV)
		{
			return null;
		}
	}

	public static class DataServerCommands
	{
		public const string GetProjects = "GTS";

		public const string GetCharts = "GAX";

		public const string GetNewID = "GID";

		public const string ChangeProps = "CCG";

		public const string PostToGame = "PTG";

		public const string History = "GLH";

		public const string Poll = "PLL";

		public const string BuildManifest = "BMF";
	}

	[Serializable]
	public class DataJSONGAXResponse
	{
		public string cmd;

		public DataJSONGAXResponseReply reply;
	}

	[Serializable]
	public class DataJSONGAXResponseReply
	{
		public int projId;

		public List<DataJSONGAXResponseReplyRecord> records;
	}

	[Serializable]
	public class DataJSONGAXResponseReplyRecord
	{
		public string defName;

		public List<DataJSONGAXResponseReplyDefRecord> defRecords;
	}

	[Serializable]
	public class DataJSONGAXResponseReplyDefRecord
	{
		public uint _id;

		public string DefName;

		public string DataJSON;
	}

	[Serializable]
	public class DataServerResponseReplyStatus
	{
		public bool status;

		public List<DataServerResponseReplyStatusReason> reason;
	}

	[Serializable]
	public class DataServerResponseReplyStatusReason
	{
		public string message;
	}

	[Serializable]
	public class DataServerResponseBase<T>
	{
		public T reply;
	}

	[Serializable]
	public class GTSResponseReply
	{
		public List<GTSResponseReplyProject> projects;
	}

	[Serializable]
	public class GTSResponseReplyProject
	{
		public int id;

		public string name;

		public string label;

		public List<GTSResponseReplyProjectDef> defs;
	}

	[Serializable]
	public class GTSResponseReplyProjectDef
	{
		public string name;

		public string label;
	}

	public class ChartDefComponent
	{
		public ChartComponentAttribute attribute;

		public Type type;

		public ChartDefComponent(ChartComponentAttribute inAttribute, Type inType)
		{
		}
	}

	public class DefEntryComponent
	{
		private DefEntry _parentDefEntry;

		private string _componentClass;

		private bool _componentIsCustom;

		private string _componentJSON;

		private string _originalComponentJSON;

		private string _cachedDiffText;

		private bool _defComponentInstanceNeedsRefresh;

		private DefComponent _defComponentInstance;

		public string ComponentClass
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ComponentIsCustom
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string ComponentJSON
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string OriginalComponentJSON
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CachedDiffText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DefComponent DefComponentInstance
		{
			get
			{
				return null;
			}
		}

		public DefEntryComponent(DefEntry inParentDefEntry)
		{
		}

		public DefEntryComponent(DefEntry inParentDefEntry, string inComponentClass)
		{
		}

		public DefEntryComponent(DefEntry inParentDefEntry, string inComponentClass, string inComponentJSON)
		{
		}

		public void AddDiffLine(string inLine, string inColorCode, bool inBold = false)
		{
		}

		public void InternalRepair()
		{
		}

		public void ClearDefComponentInstance()
		{
		}

		public void RebuildComponentJSON()
		{
		}
	}

	public class DefEntry
	{
		[Serializable]
		public class DataJSONObject
		{
			[Serializable]
			public class Component
			{
				public string componentClass;

				public string componentJSON;
			}

			public string templateClass;

			public List<Component> components;
		}

		public Chart parentChart;

		public Vector2 editorCommitDiffScrollPos;

		public int treeViewID;

		private bool _allowCommit;

		private bool _cachedValidForCommitWasSet;

		private bool _cachedValidForCommit;

		private bool _markForDelete;

		private bool _isDirty;

		public string defID;

		private string _defName;

		private string _fullCategoryName;

		private List<HistoryEntry> _historyEntries;

		private bool _cachedDiffTextWasSet;

		private string _cachedDiffText;

		private string _originalDefName;

		private string _serverDataJSON;

		private string _originalDataJSON;

		private string _originalTemplateFormatHash;

		private Dictionary<string, JsonData> _originalColumnData;

		private Dictionary<string, JsonData> _columnData;

		private string _dataJSON;

		private bool _userSetNewTemplateClass;

		private string _templateClass;

		private ChartTemplate _template;

		private string _lastTemplateClass;

		private string _templateFormatHash;

		private List<DefEntryComponent> _components;

		private static ObjectPool<StringBuilder> _stringBuilderPool;

		private List<StringBuilder> _componentJSONsTemp;

		private StringBuilder _rebuildDataJSONSB;

		public bool AllowCommit
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ValidForCommit
		{
			get
			{
				return default(bool);
			}
		}

		public bool MarkForDelete
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool FormatIsDifferentFromServer
		{
			get
			{
				return default(bool);
			}
		}

		public bool FormatIsDifferentFromCode
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsWrongFormat
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsDirty
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string DefName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FullDefName
		{
			get
			{
				return null;
			}
		}

		public string TemplateCategoryName
		{
			get
			{
				return null;
			}
		}

		public string FullCategoryName
		{
			get
			{
				return null;
			}
		}

		public bool HasHistory
		{
			get
			{
				return default(bool);
			}
		}

		public List<HistoryEntry> HistoryEntries
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CachedDiffText
		{
			get
			{
				return null;
			}
		}

		public string SearchLabel
		{
			get
			{
				return null;
			}
		}

		public string OriginalDefName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string OriginalDataJSON
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string OriginalTemplateFormatHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, JsonData> OriginalColumnData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, JsonData> ColumnData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ColumnDataDirty
		{
			get
			{
				return default(bool);
			}
		}

		public bool DataJSONEditMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string DataJSON
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TemplateClass
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ChartTemplate Template
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TemplateFormatHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<DefEntryComponent> Components
		{
			get
			{
				return null;
			}
		}

		public List<DefEntryComponent> TemplateComponents
		{
			get
			{
				return null;
			}
		}

		public List<DefEntryComponent> CustomComponents
		{
			get
			{
				return null;
			}
		}

		private static ObjectPool<StringBuilder> StringBuilderPool
		{
			get
			{
				return null;
			}
		}

		public DefEntry(Chart inParentChart, string inDefID, string inName)
		{
		}

		public DefEntry(Chart inParentChart, DataJSONGAXResponseReplyDefRecord inRecordDef)
		{
		}

		public DefEntry(Chart inParentChart, JsonData inRecordDef)
		{
		}

		public void Revert()
		{
		}

		private void AddDiffLine(string inLine, string inColorCode, bool inBold = false)
		{
		}

		public void AddComponent(DefEntryComponent inComponent)
		{
		}

		public void RemoveComponent(DefEntryComponent inComponent)
		{
		}

		public DefEntryComponent GetDefEntryComponent(string inComponentClass)
		{
			return null;
		}

		public T GetComponent<T>() where T : DefComponent
		{
			return null;
		}

		public bool RebuildFromDataJSON()
		{
			return default(bool);
		}

		private void RebuildDataJSONAddLine(string inText, int inIndentation)
		{
		}

		public void RebuildDataJSON()
		{
		}

		public bool MapComponentsToTemplate()
		{
			return default(bool);
		}
	}

	[Serializable]
	private class ExportDefEntry
	{
		[NonSerialized]
		public DefEntry defEntry;

		public string defID;

		public string defName;

		public string dataJSON;

		public ExportDefEntry(DefEntry inDefEntry)
		{
		}
	}

	[Serializable]
	private class ExportChartEntry
	{
		public string name;

		public string label;

		public List<ExportDefEntry> defs;

		public ExportChartEntry(Chart inChart)
		{
		}
	}

	[Serializable]
	private class ExportProject
	{
		public int ID;

		public string name;

		public List<ExportChartEntry> charts;

		public ExportProject(Project inProject, Chart inChart)
		{
		}

		public ExportProject(Project inProject)
		{
		}

		public ExportProject(string inJSON)
		{
		}

		public string ToJSON(bool inPretty = true)
		{
			return null;
		}

		public string ToCSV()
		{
			return null;
		}
	}

	[Serializable]
	public class HistoryEntryData
	{
		public long _id;

		public string DefName;

		public string DataJSON;

		public long modified;
	}

	[Serializable]
	public class HistoryEntry
	{
		public string user;

		public long dtStamp;

		public string command;

		public string comment;

		public HistoryEntryData data;

		public HistoryEntryData original;

		public HistoryEntryData newData;

		private string _prettyDate;

		public string PrettyDate
		{
			get
			{
				return null;
			}
		}
	}

	public class Project
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <RefreshChartsAsync>d__31 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncVoidMethodBuilder <>t__builder;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public string name;

		public string label;

		public int projID;

		public List<Chart> charts;

		private Chart _lockChart;

		private Chart _formatChart;

		public List<Chart> Charts
		{
			get
			{
				return null;
			}
		}

		public Chart LockChart
		{
			get
			{
				return null;
			}
		}

		public Chart FormatChart
		{
			get
			{
				return null;
			}
		}

		public bool IsDirty
		{
			get
			{
				return default(bool);
			}
		}

		public Chart GetChart(string inName)
		{
			return null;
		}

		public DefEntry GetDefEntry(string inID)
		{
			return null;
		}

		public ValueTuple<DefEntry, PropertyEditorLockedDefComponent> GetLockForID(string inID)
		{
			return default(ValueTuple<DefEntry, PropertyEditorLockedDefComponent>);
		}

		public void SetLockForID(string inUserName, string inDefID)
		{
		}

		public void RemoveLockForID(string inDefID)
		{
		}

		public ValueTuple<DefEntry, PropertyEditorFormatDefComponent> GetFormatForTemplateClass(string inTemplateClass)
		{
			return default(ValueTuple<DefEntry, PropertyEditorFormatDefComponent>);
		}

		public void SetFormatForTemplateClass(string inTemplateClass)
		{
		}

		public void RemoveFormatForTemplateClass(string inTemplateClass)
		{
		}

		public void RevertAll()
		{
		}

		public void CommitAllCharts(string inComment, bool inPost)
		{
		}

		[IteratorStateMachine(typeof(<CommitAllChartsRoutine>d__24))]
		public IEnumerator CommitAllChartsRoutine(string inComment, bool inPost)
		{
			return null;
		}

		public void Post()
		{
		}

		[IteratorStateMachine(typeof(<PostRoutine>d__26))]
		public IEnumerator PostRoutine()
		{
			return null;
		}

		public void BuildManifest()
		{
		}

		[IteratorStateMachine(typeof(<BuildManifestRoutine>d__28))]
		public IEnumerator BuildManifestRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<RefreshHistoryRoutine>d__29))]
		public IEnumerator RefreshHistoryRoutine(Chart inChart, DefEntry inDef, [Optional] Action<List<HistoryEntry>> inOnFinishedCallback)
		{
			return null;
		}

		public void RefreshAllCharts([Optional] Action inOnFinishedCallback)
		{
		}

		[AsyncStateMachine(typeof(<RefreshChartsAsync>d__31))]
		public void RefreshChartsAsync([Optional] List<Chart> inCharts, [Optional] Action inOnFinishedCallback)
		{
		}

		[IteratorStateMachine(typeof(<RefreshChartsRoutine>d__32))]
		public IEnumerator RefreshChartsRoutine([Optional] List<Chart> inCharts, [Optional] Action inOnFinishedCallback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<RebuildAllDataJSONsRoutine>d__33))]
		public IEnumerator RebuildAllDataJSONsRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<RefreshChartsRoutineFast>d__34))]
		public IEnumerator RefreshChartsRoutineFast([Optional] List<Chart> inCharts, [Optional] Action inOnFinishedCallback)
		{
			return null;
		}

		public string ExportAsJSON()
		{
			return null;
		}
	}

	public enum State
	{
		Idle,
		NotLoggedIn,
		LoggingIn,
		FailedLoggingIn,
		Refreshing,
		FailedRefreshing,
		RefreshingHistory,
		FailedRefreshingHistory,
		Committing,
		FailedCommitting,
		Posting,
		FailedPosting
	}

	public abstract class ChartTemplateBase
	{
		private static Dictionary<string, Func<ChartTemplateBase>> _templateConstructorDict;

		private static Dictionary<Type, string> _builtTypeFormats;

		private string _localFormatHash;

		public string LocalFormatHash
		{
			get
			{
				return null;
			}
		}

		public static ChartTemplateBase ConstructTemplate(string inTypeName)
		{
			return null;
		}

		private StringBuilder BuildFormat()
		{
			return null;
		}

		private void BuildFormatRecursively(FieldInfo inField, StringBuilder inStringBuilder, List<Type> inBuiltTypes)
		{
		}

		public virtual void OnCreateGUI()
		{
		}

		public virtual List<ValueTuple<string, string>> GetSuggestions()
		{
			return null;
		}

		public virtual void OnCreated(DefEntry inDefEntry)
		{
		}

		public virtual void OnChangeTemplate(DefEntry inDefEntry)
		{
		}

		public virtual string DefNamePrefix(DefEntry inDefEntry)
		{
			return null;
		}
	}

	public class ChartTemplate
	{
		public ChartTemplateAttribute attribute;

		public ChartTemplateBase templateInstance;

		public Type templateType;

		public Type defType;

		public List<Type> defComponentTypes;

		public ChartTemplate(ChartTemplateAttribute inAttribute, Type inType)
		{
		}
	}

	private static List<ChartDefComponent> _chartDefComponents;

	private static Dictionary<string, ValueTuple<Type, MethodInfo>> _chartDefComponentSearchMethods;

	private static string _propertyChartCacheFolderPath;

	private static List<Project> _projects;

	private static State _currentState;

	private static DateTime _currentStateSetTime;

	private static string _currentStateHeader;

	private static string _currentStateProgress;

	private static NoTemplate _cachedNoTemplate;

	private static string _cachedNoTemplateHash;

	private static MissingTemplate _cachedMissingTemplate;

	private static string _cachedMissingTemplateHash;

	private static List<ChartTemplate> _chartTemplates;

	public static bool requestRepaint;

	private static string _currentProjectName;

	private static string _currentChartName;

	private static Project _currentProject;

	private static Chart _currentChart;

	private static Dictionary<Type, Dictionary<string, List<Attribute>>> _cachedCustomAttributes;

	private static Dictionary<Type, string> _cachedTypeName;

	public static string focusNextOnGUIName;

	public static int focusNextOnGUIDoubleTap;

	public static string DataServerURL
	{
		get
		{
			return null;
		}
	}

	public static List<ChartDefComponent> ChartDefComponents
	{
		get
		{
			return null;
		}
	}

	public static Dictionary<string, ValueTuple<Type, MethodInfo>> ChartDefComponentSearchMethods
	{
		get
		{
			return null;
		}
	}

	public static bool ShowPreviews
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool AdvancedMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool FormatMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static string LoginUserName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string LoginPassword
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string PropertyChartCacheFolderPath
	{
		get
		{
			return null;
		}
	}

	public static List<Project> Projects
	{
		get
		{
			return null;
		}
	}

	public static State CurrentState
	{
		get
		{
			return default(State);
		}
		set
		{
		}
	}

	public static string CurrentStateHeader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string CurrentStateProgress
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static NoTemplate CachedNoTemplate
	{
		get
		{
			return null;
		}
	}

	public static string CachedNoTemplateHash
	{
		get
		{
			return null;
		}
	}

	public static MissingTemplate CachedMissingTemplate
	{
		get
		{
			return null;
		}
	}

	public static string CachedMissingTemplateHash
	{
		get
		{
			return null;
		}
	}

	public static List<ChartTemplate> ChartTemplates
	{
		get
		{
			return null;
		}
	}

	public static string CurrentProjectName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string CurrentChartName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Project CurrentProject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Chart CurrentChart
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[IteratorStateMachine(typeof(<DataServerRequest>d__4))]
	public static IEnumerator DataServerRequest(string inCommand, JsonData inJsonData, Action<ValueTuple<bool, JsonData>> inResultCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DataServerFastRequest>d__5<>))]
	public static IEnumerator DataServerFastRequest<T>(string inCommand, JsonData inJsonData, Action<ValueTuple<bool, DataServerResponseBase<T>>> inResultCallback) where T : class, new()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DataServerRequestDataJSONGetCharts>d__16))]
	public static IEnumerator DataServerRequestDataJSONGetCharts(JsonData inJsonData, Action<ValueTuple<bool, DataJSONGAXResponse>> inResultCallback)
	{
		return null;
	}

	public static ChartDefComponent GetChartDefComponent(string inName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<PollRoutine>d__47))]
	public static IEnumerator PollRoutine(List<string> inChartNames, Action<Dictionary<string, long>> inModifiedChartsResult, [Optional] Action inOnFinishedCallback)
	{
		return null;
	}

	public static Project GetProject(string inName)
	{
		return null;
	}

	public static void RefreshProjects([Optional] Action inOnFinishedCallback)
	{
	}

	[IteratorStateMachine(typeof(<RefreshProjectsRoutine>d__57))]
	public static IEnumerator RefreshProjectsRoutine([Optional] Action inOnFinishedCallback)
	{
		return null;
	}

	public static void RefreshProjectsAndCharts([Optional] Action inOnFinishedCallback)
	{
	}

	[IteratorStateMachine(typeof(<RefreshProjectsAndChartsRoutine>d__59))]
	public static IEnumerator RefreshProjectsAndChartsRoutine([Optional] Action inOnFinishedCallback)
	{
		return null;
	}

	public static ChartTemplate GetChartTemplate(string inName)
	{
		return null;
	}

	public static void Log(string inLog)
	{
	}

	public static void LogError(string inLog)
	{
	}

	public static List<Attribute> FastCustomAttributes(Type inType, MemberInfo inInfo)
	{
		return null;
	}

	public static string FastTypeName(Type inType)
	{
		return null;
	}

	public static void QueueFocus(string inFocusName)
	{
	}
}
