using System;
using System.Collections.Generic;
using Backtrace.Unity.Types;
using UnityEngine;

namespace Backtrace.Unity.Model
{
	[Serializable]
	[CreateAssetMenu]
	public class BacktraceConfiguration : ScriptableObject
	{
		[Header("Backtrace client configuration")]
		[Tooltip("This field is required to submit exceptions from your Unity project to your Backtrace instance.\n \nMore information about how to retrieve this value for your instance is our docs at What is a submission URL and What is a submission token?\n\nNOTE: the backtrace-unity plugin will expect full URL with token to your Backtrace instance.")]
		public string ServerUrl;

		public string Token;

		[Tooltip("Reports per minute: Limits the number of reports the client will send per minutes. If set to 0, there is no limit. If set to a higher value and the value is reached, the client will not send any reports until the next minute. Default: 50")]
		public int ReportPerMin;

		[Tooltip("Toggle this on or off to set the library to handle unhandled exceptions that are not captured by try-catch blocks.")]
		public bool HandleUnhandledExceptions;

		[Tooltip("Unity by default will validate ssl certificates. By using this option you can avoid ssl certificates validation. However, if you don't need to ignore ssl validation, please set this option to false.")]
		public bool IgnoreSslValidation;

		[Tooltip("Backtrace-client by default will be available on each scene. Once you initialize Backtrace integration, you can fetch Backtrace game object from every scene. In case if you don't want to have Backtrace-unity integration available by default in each scene, please set this value to true.")]
		public bool DestroyOnLoad;

		[Tooltip("Log random sampling rate - Enables a random sampling mechanism for unhandled exceptions - by default sampling is equal to 0.01 - which means only 1% of randomply sampling reports will be send to Backtrace. \n* 1 - means 100% of unhandled exception reports will be reported by library,\n* 0.1 - means 10% of unhandled exception reports will be reported by library,\n* 0 - means library is going to drop all unhandled exception.")]
		[Range(0f, 1f)]
		public double Sampling;

		[Tooltip("Report filter allows to filter specific type of reports. Possible options:\n* Disable - Disable report filtering - send every type of report.\n* Message - Prevent message reports.\n* Exception - Prevent exception reports.\n* Unhandled exception- Prevent unhandled exception reports.\n* Hang - Prevent sending reports when game hang.")]
		public ReportFilterType ReportFilterType;

		[Tooltip("Allows developer to filter number of game object childrens in Backtrace report.")]
		public int GameObjectDepth;

		[Tooltip("Number of logs collected by Backtrace-Unity")]
		public uint NumberOfLogs;

		[Tooltip("Enable performance statistics")]
		public bool PerformanceStatistics;

		[Tooltip("Try to find game native crashes and send them on Game startup")]
		public bool SendUnhandledGameCrashesOnGameStartup;

		[Tooltip("Client-side deduplication allows the backtrace-unity library to group multiple error reports into a single one based on various factors. Factors include:\n\n* Disable - Client-side deduplication rules are disabled.\n* Everything - Use all the options as a factor in client-side deduplication.\n* Faulting callstack - Use the faulting callstack as a factor in client-side deduplication.\n* Exception type - Use the exception type as a factor in client-side deduplication.\n* Exception message - Use the exception message as a factor in client-side deduplication.")]
		public DeduplicationStrategy DeduplicationStrategy;

		[Tooltip("If exception does not have a stack trace, use a normalized exception message to generate fingerprint.")]
		public bool UseNormalizedExceptionMessage;

		[Tooltip("Type of minidump that will be attached to Backtrace report in the report generated on Windows machine.")]
		public MiniDumpType MinidumpType;

		[Tooltip("Generate and attach screenshot of frame as exception occurs")]
		public bool GenerateScreenshotOnException;

		[Tooltip("List of path to attachments that Backtrace client will include in the native and managed reports.")]
		public string[] AttachmentPaths;

		[Tooltip("This is the path to directory where the Backtrace database will store reports on your game. NOTE: Backtrace database will remove all existing files on database start.")]
		public string DatabasePath;

		[Tooltip("When this setting is toggled, the backtrace-unity plugin will configure an offline database that will store reports if they can't be submitted do to being offline or not finding a network. When toggled on, there are a number of Database settings to configure.")]
		[Header("Backtrace database configuration")]
		public bool Enabled;

		[Tooltip("Add Unity player log file to Backtrace report")]
		public bool AddUnityLogToReport;

		[Tooltip("When toggled on, the database will send automatically reports to Backtrace server based on the Retry Settings below. When toggled off, the developer will need to use the Flush method to attempt to send and clear. Recommend that this is toggled on.")]
		public bool AutoSendMode;

		[Tooltip("If toggled, the library will create the offline database directory if the provided path doesn't exists.")]
		public bool CreateDatabase;

		[Tooltip("This is one of two limits you can impose for controlling the growth of the offline store. This setting is the maximum number of stored reports in database. If value is equal to zero, then limit not exists, When the limit is reached, the database will remove the oldest entries.")]
		public int MaxRecordCount;

		[Tooltip("This is the second limit you can impose for controlling the growth of the offline store. This setting is the maximum database size in MB. If value is equal to zero, then size is unlimited, When the limit is reached, the database will remove the oldest entries.")]
		public long MaxDatabaseSize;

		[Tooltip("If the database is unable to send its record, this setting specifies how many seconds the library should wait between retries.")]
		public int RetryInterval;

		[Tooltip("If the database is unable to send its record, this setting specifies the maximum number of retries before the system gives up.")]
		public int RetryLimit;

		[Tooltip("This specifies in which order records are sent to the Backtrace server.")]
		public RetryOrder RetryOrder;

		public string CrashpadDatabasePath
		{
			get
			{
				return null;
			}
		}

		public List<string> GetAttachmentPaths()
		{
			return null;
		}

		public string GetFullDatabasePath()
		{
			return null;
		}

		public string GetValidServerUrl()
		{
			return null;
		}

		public static string UpdateServerUrl(string value)
		{
			return null;
		}

		public static bool ValidateServerUrl(string value)
		{
			return default(bool);
		}

		public bool IsValid()
		{
			return default(bool);
		}

		public BacktraceCredentials ToCredentials()
		{
			return null;
		}
	}
}
