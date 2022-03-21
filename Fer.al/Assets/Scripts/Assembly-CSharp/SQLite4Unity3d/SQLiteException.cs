using System;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	public class SQLiteException : Exception
	{
		public SQLite3.Result Result
		{
			[CompilerGenerated]
			get
			{
				return default(SQLite3.Result);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected SQLiteException(SQLite3.Result r, string message)
		{
		}

		public static SQLiteException New(SQLite3.Result r, string message)
		{
			return null;
		}
	}
}
