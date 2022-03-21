using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	public class SQLiteConnection : IDisposable
	{
		public delegate void TraceHandler(string message);

		public delegate void TimeExecutionHandler(TimeSpan executionTime, TimeSpan totalExecutionTime);

		private struct IndexedColumn
		{
			public int Order;

			public string ColumnName;
		}

		private struct IndexInfo
		{
			public string IndexName;

			public string TableName;

			public bool Unique;

			public List<IndexedColumn> Columns;
		}

		public class ColumnInfo
		{
			[Column("name")]
			public string Name
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

			public int notnull
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public override string ToString()
			{
				return null;
			}
		}

		private bool _open;

		private TimeSpan _busyTimeout;

		private Dictionary<string, TableMapping> _mappings;

		private Dictionary<string, TableMapping> _tables;

		private Stopwatch _sw;

		private TimeSpan _elapsed;

		private int _transactionDepth;

		private Random _rand;

		internal static readonly IntPtr NullHandle;

		private static Dictionary<string, object> syncObjects;

		private static bool _preserveDuringLinkMagic;

		public IntPtr Handle
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string DatabasePath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool Trace
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

		public bool TimeExecution
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

		public bool StoreDateTimeAsTicks
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

		public object SyncObject
		{
			get
			{
				return null;
			}
		}

		public TimeSpan BusyTimeout
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		public IEnumerable<TableMapping> TableMappings
		{
			get
			{
				return null;
			}
		}

		public bool IsInTransaction
		{
			get
			{
				return default(bool);
			}
		}

		public event TraceHandler TraceEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event TimeExecutionHandler TimeExecutionEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal void InvokeTrace(string message)
		{
		}

		internal void InvokeTimeExecution(TimeSpan executionTime, TimeSpan totalExecutionTime)
		{
		}

		public SQLiteConnection(string databasePath, bool storeDateTimeAsTicks = false)
		{
		}

		public SQLiteConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = false)
		{
		}

		static SQLiteConnection()
		{
		}

		private void mayCreateSyncObject(string databasePath)
		{
		}

		public void EnableLoadExtension(int onoff)
		{
		}

		private static byte[] GetNullTerminatedUtf8(string s)
		{
			return null;
		}

		public TableMapping GetMapping(Type type, CreateFlags createFlags = CreateFlags.None)
		{
			return null;
		}

		public TableMapping GetMapping<T>()
		{
			return null;
		}

		public int DropTable<T>()
		{
			return default(int);
		}

		public int CreateTable<T>(CreateFlags createFlags = CreateFlags.None)
		{
			return default(int);
		}

		public int CreateTable(Type ty, CreateFlags createFlags = CreateFlags.None)
		{
			return default(int);
		}

		public int CreateIndex(string indexName, string tableName, string[] columnNames, bool unique = false)
		{
			return default(int);
		}

		public int CreateIndex(string indexName, string tableName, string columnName, bool unique = false)
		{
			return default(int);
		}

		public int CreateIndex(string tableName, string columnName, bool unique = false)
		{
			return default(int);
		}

		public int CreateIndex(string tableName, string[] columnNames, bool unique = false)
		{
			return default(int);
		}

		public void CreateIndex<T>(Expression<Func<T, object>> property, bool unique = false)
		{
		}

		public List<ColumnInfo> GetTableInfo(string tableName)
		{
			return null;
		}

		private void MigrateTable(TableMapping map)
		{
		}

		protected virtual SQLiteCommand NewCommand()
		{
			return null;
		}

		public SQLiteCommand CreateCommand(string cmdText, object[] ps)
		{
			return null;
		}

		public int Execute(string query, object[] args)
		{
			return default(int);
		}

		public T ExecuteScalar<T>(string query, object[] args)
		{
			return (T)null;
		}

		public List<T> Query<T>(string query, object[] args) where T : new()
		{
			return null;
		}

		public IEnumerable<T> DeferredQuery<T>(string query, object[] args) where T : new()
		{
			return null;
		}

		public List<object> Query(TableMapping map, string query, object[] args)
		{
			return null;
		}

		public IEnumerable<object> DeferredQuery(TableMapping map, string query, object[] args)
		{
			return null;
		}

		public TableQuery<T> Table<T>() where T : new()
		{
			return null;
		}

		public T Get<T>(object pk) where T : new()
		{
			return (T)null;
		}

		public T Get<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return (T)null;
		}

		public T Find<T>(object pk) where T : new()
		{
			return (T)null;
		}

		public object Find(object pk, TableMapping map)
		{
			return null;
		}

		public T Find<T>(Expression<Func<T, bool>> predicate) where T : new()
		{
			return (T)null;
		}

		public void BeginTransaction()
		{
		}

		public string SaveTransactionPoint()
		{
			return null;
		}

		public void Rollback()
		{
		}

		public void RollbackTo(string savepoint)
		{
		}

		private void RollbackTo(string savepoint, bool noThrow)
		{
		}

		public void Release(string savepoint)
		{
		}

		private void DoSavePointExecute(string savepoint, string cmd)
		{
		}

		public void Commit()
		{
		}

		public void RunInTransaction(Action action)
		{
		}

		public void RunInDatabaseLock(Action action)
		{
		}

		public int InsertAll(IEnumerable objects)
		{
			return default(int);
		}

		public int InsertAll(IEnumerable objects, string extra)
		{
			return default(int);
		}

		public int InsertAll(IEnumerable objects, Type objType)
		{
			return default(int);
		}

		public int Insert(object obj)
		{
			return default(int);
		}

		public int InsertOrReplace(object obj)
		{
			return default(int);
		}

		public int Insert(object obj, Type objType)
		{
			return default(int);
		}

		public int InsertOrReplace(object obj, Type objType)
		{
			return default(int);
		}

		public int Insert(object obj, string extra)
		{
			return default(int);
		}

		public int Insert(object obj, string extra, Type objType)
		{
			return default(int);
		}

		public int Update(object obj)
		{
			return default(int);
		}

		public int Update(object obj, Type objType)
		{
			return default(int);
		}

		public int UpdateAll(IEnumerable objects)
		{
			return default(int);
		}

		public int Delete(object objectToDelete)
		{
			return default(int);
		}

		public int Delete<T>(object primaryKey)
		{
			return default(int);
		}

		public int DeleteAll<T>()
		{
			return default(int);
		}

		~SQLiteConnection()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Close()
		{
		}
	}
}
