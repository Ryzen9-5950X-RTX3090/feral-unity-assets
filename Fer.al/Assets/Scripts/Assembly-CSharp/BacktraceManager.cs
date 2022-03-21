using Backtrace.Unity;
using UnityEngine;

public class BacktraceManager : SingletonManagerBase<BacktraceManager>
{
	private static BacktraceClient _backtraceClient;

	[SerializeField]
	private string _defaultServerUrl;

	[SerializeField]
	[RootSelector("Enabled", "GlobalChartData", false, false)]
	private string _enabled;

	[SerializeField]
	[RootSelector("ServerUrl", "GlobalChartData", false, false)]
	private string _serverUrl;

	[SerializeField]
	[RootSelector("Sampling", "GlobalChartData", false, false)]
	private string _sampling;

	[SerializeField]
	[RootSelector("ReportPerMin", "GlobalChartData", false, false)]
	private string _reportPerMin;

	[SerializeField]
	[RootSelector("PerformanceStatistics", "GlobalChartData", false, false)]
	private string _performanceStatistics;

	[SerializeField]
	[RootSelector("SendUnhandledGameCrashesOnGameStartup", "GlobalChartData", false, false)]
	private string _sendUnhandledGameCrashesOnGameStartup;

	[SerializeField]
	[RootSelector("RetryInterval", "GlobalChartData", false, false)]
	private string _retryInterval;

	[SerializeField]
	[RootSelector("RetryLimit", "GlobalChartData", false, false)]
	private string _retryLimit;

	[SerializeField]
	[RootSelector("UseNormalizedExceptionMessage", "GlobalChartData", false, false)]
	private string _useNormalizedExceptionMessage;

	[SerializeField]
	[RootSelector("AddUnityLogToReport", "GlobalChartData", false, false)]
	private string _addUnityLogToReport;

	[SerializeField]
	[RootSelector("GameObjectDepth", "GlobalChartData", false, false)]
	private string _gameObjectDepth;

	[SerializeField]
	[RootSelector("GenerateScreenshotOnException", "GlobalChartData", false, false)]
	private string _generateScreenshotOnException;

	[SerializeField]
	[RootSelector("HandleUnhandledExceptions", "GlobalChartData", false, false)]
	private string _handleUnhandledExceptions;

	[SerializeField]
	[RootSelector("IgnoreSslValidation", "GlobalChartData", false, false)]
	private string _ignoreSslValidation;

	[SerializeField]
	[RootSelector("ReportFilterType", "GlobalChartData", false, false)]
	private string _reportFilterType;

	[SerializeField]
	[RootSelector("DeduplicationStrategy", "GlobalChartData", false, false)]
	private string _deduplicationStrategy;

	[SerializeField]
	[RootSelector("CreateDatabase", "GlobalChartData", false, false)]
	private string _createDatabase;

	[SerializeField]
	[RootSelector("MaxRecordCount", "GlobalChartData", false, false)]
	private string _maxRecordCount;

	[SerializeField]
	[RootSelector("MaxDatabaseSize", "GlobalChartData", false, false)]
	private string _maxDatabaseSize;

	[SerializeField]
	[RootSelector("AutoSendMode", "GlobalChartData", false, false)]
	private string _autoSendMode;

	public override void MStart()
	{
	}
}
