using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	public class TableQuery<T> : BaseTableQuery, IEnumerable<T>, IEnumerable
	{
		private class CompileResult
		{
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
		}

		private Expression _where;

		private List<Ordering> _orderBys;

		private int? _limit;

		private int? _offset;

		private BaseTableQuery _joinInner;

		private Expression _joinInnerKeySelector;

		private BaseTableQuery _joinOuter;

		private Expression _joinOuterKeySelector;

		private Expression _joinSelector;

		private Expression _selector;

		private bool _deferred;

		public SQLiteConnection Connection
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

		public TableMapping Table
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

		private TableQuery(SQLiteConnection conn, TableMapping table)
		{
		}

		public TableQuery(SQLiteConnection conn)
		{
		}

		public TableQuery<U> Clone<U>()
		{
			return null;
		}

		public TableQuery<T> Where(Expression<Func<T, bool>> predExpr)
		{
			return null;
		}

		public TableQuery<T> Take(int n)
		{
			return null;
		}

		public TableQuery<T> Skip(int n)
		{
			return null;
		}

		public T ElementAt(int index)
		{
			return (T)null;
		}

		public TableQuery<T> Deferred()
		{
			return null;
		}

		public TableQuery<T> OrderBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		public TableQuery<T> OrderByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		public TableQuery<T> ThenBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		public TableQuery<T> ThenByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return null;
		}

		private TableQuery<T> AddOrderBy<U>(Expression<Func<T, U>> orderExpr, bool asc)
		{
			return null;
		}

		private void AddWhere(Expression pred)
		{
		}

		public TableQuery<TResult> Join<TResult, TInner, TKey>(TableQuery<TInner> inner, Expression<Func<T, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<T, TInner, TResult>> resultSelector)
		{
			return null;
		}

		public TableQuery<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
		{
			return null;
		}

		private SQLiteCommand GenerateCommand(string selectionList)
		{
			return null;
		}

		private CompileResult CompileExpr(Expression expr, List<object> queryArgs)
		{
			return null;
		}

		private static object ConvertTo(object obj, Type t)
		{
			return null;
		}

		private string CompileNullBinaryExpression(BinaryExpression expression, CompileResult parameter)
		{
			return null;
		}

		private string GetSqlName(Expression expr)
		{
			return null;
		}

		public int Count()
		{
			return default(int);
		}

		public int Count(Expression<Func<T, bool>> predExpr)
		{
			return default(int);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public T First()
		{
			return (T)null;
		}

		public T FirstOrDefault()
		{
			return (T)null;
		}
	}
}
