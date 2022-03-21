using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	public class TableMapping
	{
		public class Column
		{
			private PropertyInfo _prop;

			public string Name
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

			public string PropertyName
			{
				get
				{
					return null;
				}
			}

			public Type ColumnType
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

			public string Collation
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

			public bool IsAutoInc
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

			public bool IsAutoGuid
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

			public bool IsPK
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

			public IEnumerable<IndexedAttribute> Indices
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

			public bool IsNullable
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

			public int? MaxStringLength
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

			public Column(PropertyInfo prop, CreateFlags createFlags = CreateFlags.None)
			{
			}

			public void SetValue(object obj, object val)
			{
			}

			public object GetValue(object obj)
			{
				return null;
			}
		}

		private Column _autoPk;

		private Column[] _insertColumns;

		private Column[] _insertOrReplaceColumns;

		private PreparedSqlLiteInsertCommand _insertCommand;

		private string _insertCommandExtra;

		public Type MappedType
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

		public string TableName
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

		public Column[] Columns
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

		public Column PK
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

		public string GetByPrimaryKeySql
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

		public bool HasAutoIncPK
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

		public Column[] InsertColumns
		{
			get
			{
				return null;
			}
		}

		public Column[] InsertOrReplaceColumns
		{
			get
			{
				return null;
			}
		}

		public TableMapping(Type type, CreateFlags createFlags = CreateFlags.None)
		{
		}

		public void SetAutoIncPK(object obj, long id)
		{
		}

		public Column FindColumnWithPropertyName(string propertyName)
		{
			return null;
		}

		public Column FindColumn(string columnName)
		{
			return null;
		}

		public PreparedSqlLiteInsertCommand GetInsertCommand(SQLiteConnection conn, string extra)
		{
			return null;
		}

		private PreparedSqlLiteInsertCommand CreateInsertCommand(SQLiteConnection conn, string extra)
		{
			return null;
		}

		protected internal void Dispose()
		{
		}
	}
}
