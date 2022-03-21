using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	public class NotNullConstraintViolationException : SQLiteException
	{
		public IEnumerable<TableMapping.Column> Columns
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

		protected NotNullConstraintViolationException(SQLite3.Result r, string message)
		{
		}

		protected NotNullConstraintViolationException(SQLite3.Result r, string message, TableMapping mapping, object obj)
		{
		}

		public new static NotNullConstraintViolationException New(SQLite3.Result r, string message)
		{
			return null;
		}

		public static NotNullConstraintViolationException New(SQLite3.Result r, string message, TableMapping mapping, object obj)
		{
			return null;
		}

		public static NotNullConstraintViolationException New(SQLiteException exception, TableMapping mapping, object obj)
		{
			return null;
		}
	}
}
