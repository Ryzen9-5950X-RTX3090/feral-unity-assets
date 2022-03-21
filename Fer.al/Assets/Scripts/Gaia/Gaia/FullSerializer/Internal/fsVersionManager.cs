using System;
using System.Collections.Generic;

namespace Gaia.FullSerializer.Internal
{
	public static class fsVersionManager
	{
		private static readonly Dictionary<Type, fsOption<fsVersionedType>> _cache;

		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path)
		{
			return default(fsResult);
		}

		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current)
		{
			return default(bool);
		}

		public static fsOption<fsVersionedType> GetVersionedType(Type type)
		{
			return default(fsOption<fsVersionedType>);
		}

		private static void VerifyConstructors(fsVersionedType type)
		{
		}

		private static void VerifyUniqueVersionStrings(fsVersionedType type)
		{
		}
	}
}
