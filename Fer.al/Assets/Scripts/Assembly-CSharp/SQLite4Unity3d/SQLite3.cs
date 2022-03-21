using System;

namespace SQLite4Unity3d
{
	public static class SQLite3
	{
		public enum Result
		{
			OK = 0,
			Error = 1,
			Internal = 2,
			Perm = 3,
			Abort = 4,
			Busy = 5,
			Locked = 6,
			NoMem = 7,
			ReadOnly = 8,
			Interrupt = 9,
			IOError = 10,
			Corrupt = 11,
			NotFound = 12,
			Full = 13,
			CannotOpen = 14,
			LockErr = 15,
			Empty = 16,
			SchemaChngd = 17,
			TooBig = 18,
			Constraint = 19,
			Mismatch = 20,
			Misuse = 21,
			NotImplementedLFS = 22,
			AccessDenied = 23,
			Format = 24,
			Range = 25,
			NonDBFile = 26,
			Notice = 27,
			Warning = 28,
			Row = 100,
			Done = 101
		}

		public enum ExtendedResult
		{
			IOErrorRead = 266,
			IOErrorShortRead = 522,
			IOErrorWrite = 778,
			IOErrorFsync = 1034,
			IOErrorDirFSync = 1290,
			IOErrorTruncate = 1546,
			IOErrorFStat = 1802,
			IOErrorUnlock = 2058,
			IOErrorRdlock = 2314,
			IOErrorDelete = 2570,
			IOErrorBlocked = 2826,
			IOErrorNoMem = 3082,
			IOErrorAccess = 3338,
			IOErrorCheckReservedLock = 3594,
			IOErrorLock = 3850,
			IOErrorClose = 4106,
			IOErrorDirClose = 4362,
			IOErrorSHMOpen = 4618,
			IOErrorSHMSize = 4874,
			IOErrorSHMLock = 5130,
			IOErrorSHMMap = 5386,
			IOErrorSeek = 5642,
			IOErrorDeleteNoEnt = 5898,
			IOErrorMMap = 6154,
			LockedSharedcache = 262,
			BusyRecovery = 261,
			CannottOpenNoTempDir = 270,
			CannotOpenIsDir = 526,
			CannotOpenFullPath = 782,
			CorruptVTab = 267,
			ReadonlyRecovery = 264,
			ReadonlyCannotLock = 520,
			ReadonlyRollback = 776,
			AbortRollback = 516,
			ConstraintCheck = 275,
			ConstraintCommitHook = 531,
			ConstraintForeignKey = 787,
			ConstraintFunction = 1043,
			ConstraintNotNull = 1299,
			ConstraintPrimaryKey = 1555,
			ConstraintTrigger = 1811,
			ConstraintUnique = 2067,
			ConstraintVTab = 2323,
			NoticeRecoverWAL = 283,
			NoticeRecoverRollback = 539
		}

		public enum ConfigOption
		{
			SingleThread = 1,
			MultiThread,
			Serialized
		}

		public enum ColType
		{
			Integer = 1,
			Float,
			Text,
			Blob,
			Null
		}

		public static extern Result Open(string filename, out IntPtr db);

		public static extern Result Open(string filename, out IntPtr db, int flags, IntPtr zvfs);

		public static extern Result Open(byte[] filename, out IntPtr db, int flags, IntPtr zvfs);

		public static extern Result Open16(string filename, out IntPtr db);

		public static extern Result EnableLoadExtension(IntPtr db, int onoff);

		public static extern Result Close(IntPtr db);

		public static extern Result Initialize();

		public static extern Result Shutdown();

		public static extern Result Config(ConfigOption option);

		public static extern int SetDirectory(uint directoryType, string directoryPath);

		public static extern Result BusyTimeout(IntPtr db, int milliseconds);

		public static extern int Changes(IntPtr db);

		public static extern Result Prepare2(IntPtr db, string sql, int numBytes, out IntPtr stmt, IntPtr pzTail);

		public static IntPtr Prepare2(IntPtr db, string query)
		{
			return default(IntPtr);
		}

		public static extern Result Step(IntPtr stmt);

		public static extern Result Reset(IntPtr stmt);

		public static extern Result Finalize(IntPtr stmt);

		public static extern long LastInsertRowid(IntPtr db);

		public static extern IntPtr Errmsg(IntPtr db);

		public static string GetErrmsg(IntPtr db)
		{
			return null;
		}

		public static extern int BindParameterIndex(IntPtr stmt, string name);

		public static extern int BindNull(IntPtr stmt, int index);

		public static extern int BindInt(IntPtr stmt, int index, int val);

		public static extern int BindInt64(IntPtr stmt, int index, long val);

		public static extern int BindDouble(IntPtr stmt, int index, double val);

		public static extern int BindText(IntPtr stmt, int index, string val, int n, IntPtr free);

		public static extern int BindBlob(IntPtr stmt, int index, byte[] val, int n, IntPtr free);

		public static extern int ColumnCount(IntPtr stmt);

		public static extern IntPtr ColumnName(IntPtr stmt, int index);

		private static extern IntPtr ColumnName16Internal(IntPtr stmt, int index);

		public static string ColumnName16(IntPtr stmt, int index)
		{
			return null;
		}

		public static extern ColType ColumnType(IntPtr stmt, int index);

		public static extern int ColumnInt(IntPtr stmt, int index);

		public static extern long ColumnInt64(IntPtr stmt, int index);

		public static extern double ColumnDouble(IntPtr stmt, int index);

		public static extern IntPtr ColumnText(IntPtr stmt, int index);

		public static extern IntPtr ColumnText16(IntPtr stmt, int index);

		public static extern IntPtr ColumnBlob(IntPtr stmt, int index);

		public static extern int ColumnBytes(IntPtr stmt, int index);

		public static string ColumnString(IntPtr stmt, int index)
		{
			return null;
		}

		public static byte[] ColumnByteArray(IntPtr stmt, int index)
		{
			return null;
		}

		public static extern ExtendedResult ExtendedErrCode(IntPtr db);

		public static extern int LibVersionNumber();
	}
}
