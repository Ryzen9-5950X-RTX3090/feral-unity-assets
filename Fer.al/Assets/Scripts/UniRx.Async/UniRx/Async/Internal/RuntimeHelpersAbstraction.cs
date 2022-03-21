using System;

namespace UniRx.Async.Internal
{
	internal static class RuntimeHelpersAbstraction
	{
		private static class WellKnownNoReferenceContainsType<T>
		{
			public static readonly bool IsWellKnownType;

			static WellKnownNoReferenceContainsType()
			{
			}
		}

		public static bool IsWellKnownNoReferenceContainsType<T>()
		{
			return default(bool);
		}

		private static bool WellKnownNoReferenceContainsTypeInitialize(Type t)
		{
			return default(bool);
		}
	}
}
