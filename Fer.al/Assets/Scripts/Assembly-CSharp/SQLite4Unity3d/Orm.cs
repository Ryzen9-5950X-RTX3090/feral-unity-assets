using System.Collections.Generic;
using System.Reflection;

namespace SQLite4Unity3d
{
	public static class Orm
	{
		public const int DefaultMaxStringLength = 140;

		public const string ImplicitPkName = "Id";

		public const string ImplicitIndexSuffix = "Id";

		public static string SqlDecl(TableMapping.Column p, bool storeDateTimeAsTicks)
		{
			return null;
		}

		public static string SqlType(TableMapping.Column p, bool storeDateTimeAsTicks)
		{
			return null;
		}

		public static bool IsPK(MemberInfo p)
		{
			return default(bool);
		}

		public static string Collation(MemberInfo p)
		{
			return null;
		}

		public static bool IsAutoInc(MemberInfo p)
		{
			return default(bool);
		}

		public static IEnumerable<IndexedAttribute> GetIndices(MemberInfo p)
		{
			return null;
		}

		public static int? MaxStringLength(PropertyInfo p)
		{
			return null;
		}

		public static bool IsMarkedNotNull(MemberInfo p)
		{
			return default(bool);
		}
	}
}
