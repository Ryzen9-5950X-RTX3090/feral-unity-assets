using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Services;
using Backtrace.Unity.Types;
using UnityEngine;

namespace Backtrace.Unity
{
	[RequireComponent(typeof(BacktraceClient))]
	public class BacktraceDatabase : MonoBehaviour, IBacktraceDatabase
	{
		private bool _timerBackgroundWork;

		public BacktraceConfiguration Configuration;

		internal static float LastFrameTime;

		private static BacktraceDatabase _instance;

		private float _lastConnection;

		private ReportLimitWatcher _reportLimitWatcher;

		public string DatabasePath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public static BacktraceDatabase Instance
		{
			get
			{
				return null;
			}
		}

		public DeduplicationStrategy DeduplicationStrategy
		{
			get
			{
				return default(DeduplicationStrategy);
			}
			set
			{
			}
		}

		protected BacktraceDatabaseSettings DatabaseSettings
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

		public IBacktraceApi BacktraceApi
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

		protected virtual IBacktraceDatabaseContext BacktraceDatabaseContext
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

		internal IBacktraceDatabaseFileContext BacktraceDatabaseFileContext
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

		public bool Enable
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

		public void Reload()
		{
		}

		public void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Start()
		{
		}

		public void SetApi(IBacktraceApi backtraceApi)
		{
		}

		public bool Enabled()
		{
			return default(bool);
		}

		public BacktraceDatabaseSettings GetSettings()
		{
			return null;
		}

		public void Clear()
		{
		}

		public BacktraceDatabaseRecord Add(BacktraceData data, bool @lock = true)
		{
			return null;
		}

		[Obsolete]
		public BacktraceDatabaseRecord Add(BacktraceReport backtraceReport, Dictionary<string, string> attributes, MiniDumpType miniDumpType = MiniDumpType.None)
		{
			return null;
		}

		public IEnumerable<BacktraceDatabaseRecord> Get()
		{
			return null;
		}

		public void Delete(BacktraceDatabaseRecord record)
		{
		}

		public void Flush()
		{
		}

		public void Send()
		{
		}

		private void FlushRecord(BacktraceDatabaseRecord record)
		{
		}

		private void SendData(BacktraceDatabaseRecord record)
		{
		}

		public int Count()
		{
			return default(int);
		}

		protected virtual void RemoveOrphaned()
		{
		}

		protected virtual void SetupMultisceneSupport()
		{
		}

		protected virtual bool InitializeDatabasePaths()
		{
			return default(bool);
		}

		protected virtual void LoadReports()
		{
		}

		private bool ValidateDatabaseSize()
		{
			return default(bool);
		}

		public bool ValidConsistency()
		{
			return default(bool);
		}

		public long GetDatabaseSize()
		{
			return default(long);
		}

		public void SetReportWatcher(ReportLimitWatcher reportLimitWatcher)
		{
		}
	}
}
