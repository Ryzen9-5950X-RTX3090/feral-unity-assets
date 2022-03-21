using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Newtonsoft.Json.Utilities
{
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject
	{
		private delegate DynamicMetaObject Fallback(DynamicMetaObject errorSuggestion);

		private readonly DynamicProxy<T> _proxy;

		private static Expression[] NoArgs
		{
			get
			{
				return null;
			}
		}

		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
		{
		}

		private bool IsOverridden(string method)
		{
			return default(bool);
		}

		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		private static IEnumerable<Expression> GetArgs(DynamicMetaObject[] args)
		{
			return null;
		}

		private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			return null;
		}

		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback, [Optional] Fallback fallbackInvoke)
		{
			return null;
		}

		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke)
		{
			return null;
		}

		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback)
		{
			return null;
		}

		private BindingRestrictions GetRestrictions()
		{
			return null;
		}

		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}
	}
}
