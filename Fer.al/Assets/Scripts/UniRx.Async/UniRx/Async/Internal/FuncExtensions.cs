using System;

namespace UniRx.Async.Internal
{
	internal static class FuncExtensions
	{
		internal static Action<T> AsFuncOfT<T>(this Action action)
		{
			return null;
		}

		private static void Invoke<T>(this Action action, T unused)
		{
		}
	}
}
