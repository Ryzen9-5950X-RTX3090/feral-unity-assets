using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Runtime.Native;
using Backtrace.Unity.Services;
using Backtrace.Unity.Types;
using UnityEngine;

namespace Backtrace.Unity
{
	public class BacktraceClient : MonoBehaviour
	{
		public BacktraceConfiguration Configuration;

		public const string VERSION = "3.4.0";

		private readonly Dictionary<string, string> _clientAttributes;

		internal readonly Stack<BacktraceReport> BackgroundExceptions;

		private List<string> _clientReportAttachments;

		private static BacktraceClient _instance;

		public IBacktraceDatabase Database;

		private IBacktraceApi _backtraceApi;

		private ReportLimitWatcher _reportLimitWatcher;

		internal Action<BacktraceReport> _onClientReportLimitReached;

		public Func<BacktraceData, BacktraceData> BeforeSend;

		public Func<ReportFilterType, Exception, string, bool> SkipReport;

		public Action<Exception> OnUnhandledApplicationException;

		private INativeClient _nativeClient;

		private BacktraceLogManager _backtraceLogManager;

		private Thread _current;

		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string this[string index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static BacktraceClient Instance
		{
			get
			{
				return null;
			}
		}

		public Action<Exception> OnServerError
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Func<string, BacktraceData, BacktraceResult> RequestHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<BacktraceResult> OnServerResponse
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<BacktraceReport> OnClientReportLimitReached
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool EnablePerformanceStatistics
		{
			get
			{
				return default(bool);
			}
		}

		public int GameObjectDepth
		{
			get
			{
				return default(int);
			}
		}

		internal IBacktraceApi BacktraceApi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ReportLimitWatcher ReportLimitWatcher
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void AddAttachment(string pathToAttachment)
		{
		}

		public List<string> GetAttachments()
		{
			return null;
		}

		public void SetAttributes(Dictionary<string, string> attributes)
		{
		}

		public int GetAttributesCount()
		{
			return default(int);
		}

		public static BacktraceClient Initialize(BacktraceConfiguration configuration, [Optional] Dictionary<string, string> attributes, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		public static BacktraceClient Initialize(string url, string databasePath, [Optional] Dictionary<string, string> attributes, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		public static BacktraceClient Initialize(string url, string databasePath, [Optional] Dictionary<string, string> attributes, [Optional] string[] attachments, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		public static BacktraceClient Initialize(string url, [Optional] Dictionary<string, string> attributes, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		public static BacktraceClient Initialize(string url, [Optional] Dictionary<string, string> attributes, [Optional] string[] attachments, string gameObjectName = "BacktraceClient")
		{
			return null;
		}

		public void OnDisable()
		{
		}

		public void Refresh()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetClientReportLimit(uint reportPerMin)
		{
		}

		public void Send(string message, [Optional] List<string> attachmentPaths, [Optional] Dictionary<string, string> attributes)
		{
		}

		public void Send(Exception exception, [Optional] List<string> attachmentPaths, [Optional] Dictionary<string, string> attributes)
		{
		}

		public void Send(BacktraceReport report, [Optional] Action<BacktraceResult> sendCallback)
		{
		}

		private void SendReport(BacktraceReport report, [Optional] Action<BacktraceResult> sendCallback)
		{
		}

		[IteratorStateMachine(typeof(<CollectDataAndSend>d__66))]
		private IEnumerator CollectDataAndSend(BacktraceReport report, Action<BacktraceResult> sendCallback)
		{
			return null;
		}

		private BacktraceData SetupBacktraceData(BacktraceReport report)
		{
			return null;
		}

		private void CaptureUnityMessages()
		{
		}

		internal void OnApplicationPause(bool pause)
		{
		}

		internal void HandleUnityBackgroundException(string message, string stackTrace, LogType type)
		{
		}

		internal void HandleUnityMessage(string message, string stackTrace, LogType type)
		{
		}

		private bool SamplingShouldSkip()
		{
			return default(bool);
		}

		private void SendUnhandledException(BacktraceUnhandledException exception, bool invokeSkipApi = true)
		{
		}

		private bool ShouldSendReport(Exception exception, List<string> attachmentPaths, Dictionary<string, string> attributes, bool invokeSkipApi = true)
		{
			return default(bool);
		}

		private bool ShouldSendReport(string message, List<string> attachmentPaths, Dictionary<string, string> attributes)
		{
			return default(bool);
		}

		private bool ShouldSendReport(BacktraceReport report)
		{
			return default(bool);
		}

		private void HandleInnerException(BacktraceReport report)
		{
		}

		private bool ValidClientConfiguration()
		{
			return default(bool);
		}

		private bool ShouldSkipReport(ReportFilterType type, Exception exception, string message)
		{
			return default(bool);
		}
	}
}
