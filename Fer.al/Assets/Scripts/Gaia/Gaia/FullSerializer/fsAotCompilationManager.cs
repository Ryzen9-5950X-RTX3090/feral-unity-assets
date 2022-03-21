using System;
using System.Collections.Generic;
using Gaia.FullSerializer.Internal;

namespace Gaia.FullSerializer
{
	public class fsAotCompilationManager
	{
		private struct AotCompilation
		{
			public Type Type;

			public fsMetaProperty[] Members;

			public bool IsConstructorPublic;
		}

		private static Dictionary<Type, string> _computedAotCompilations;

		private static List<AotCompilation> _uncomputedAotCompilations;

		public static Dictionary<Type, string> AvailableAotCompilations
		{
			get
			{
				return null;
			}
		}

		public static bool TryToPerformAotCompilation(Type type, out string aotCompiledClassInCSharp)
		{
			return default(bool);
		}

		public static void AddAotCompilation(Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
		}

		private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
			return null;
		}
	}
}
