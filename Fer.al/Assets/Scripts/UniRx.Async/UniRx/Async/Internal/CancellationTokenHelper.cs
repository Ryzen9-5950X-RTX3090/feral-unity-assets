using System.Threading;

namespace UniRx.Async.Internal
{
	internal static class CancellationTokenHelper
	{
		public static bool TrySetOrLinkCancellationToken(ref CancellationToken field, CancellationToken newCancellationToken)
		{
			return default(bool);
		}
	}
}
