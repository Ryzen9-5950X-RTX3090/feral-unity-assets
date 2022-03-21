using System;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	public class PreparedSqlLiteInsertCommand : IDisposable
	{
		internal static readonly IntPtr NullStatement;

		public bool Initialized
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

		protected SQLiteConnection Connection
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

		public string CommandText
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

		protected IntPtr Statement
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal PreparedSqlLiteInsertCommand(SQLiteConnection conn)
		{
		}

		public int ExecuteNonQuery(object[] source)
		{
			return default(int);
		}

		protected virtual IntPtr Prepare()
		{
			return default(IntPtr);
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		~PreparedSqlLiteInsertCommand()
		{
		}
	}
}
