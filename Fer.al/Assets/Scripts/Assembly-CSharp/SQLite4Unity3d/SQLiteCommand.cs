using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	public class SQLiteCommand
	{
		private class Binding
		{
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

			public object Value
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

			public int Index
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
		}

		private SQLiteConnection _conn;

		private List<Binding> _bindings;

		internal static IntPtr NegativePointer;

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

		internal SQLiteCommand(SQLiteConnection conn)
		{
		}

		public int ExecuteNonQuery()
		{
			return default(int);
		}

		public IEnumerable<T> ExecuteDeferredQuery<T>()
		{
			return null;
		}

		public List<T> ExecuteQuery<T>()
		{
			return null;
		}

		public List<T> ExecuteQuery<T>(TableMapping map)
		{
			return null;
		}

		protected virtual void OnInstanceCreated(object obj)
		{
		}

		[IteratorStateMachine(typeof(<ExecuteDeferredQuery>d__12<>))]
		public IEnumerable<T> ExecuteDeferredQuery<T>(TableMapping map)
		{
			return null;
		}

		public T ExecuteScalar<T>()
		{
			return (T)null;
		}

		public void Bind(string name, object val)
		{
		}

		public void Bind(object val)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private IntPtr Prepare()
		{
			return default(IntPtr);
		}

		private void Finalize(IntPtr stmt)
		{
		}

		private void BindAll(IntPtr stmt)
		{
		}

		internal static void BindParameter(IntPtr stmt, int index, object value, bool storeDateTimeAsTicks)
		{
		}

		private object ReadCol(IntPtr stmt, int index, SQLite3.ColType type, Type clrType)
		{
			return null;
		}
	}
}
