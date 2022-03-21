using System.Collections.Generic;

namespace UniRx.Async.Internal
{
	internal static class PromiseHelper
	{
		internal static void TrySetResultAll<TPromise, T>(IEnumerable<TPromise> source, T value) where TPromise : class, IResolvePromise<T>
		{
		}
	}
}
