using System.Collections.Generic;
using System.Threading;

namespace UniRx.Async
{
	public class CancellationTokenEqualityComparer : IEqualityComparer<CancellationToken>
	{
		public static readonly IEqualityComparer<CancellationToken> Default;

		public bool Equals(CancellationToken x, CancellationToken y)
		{
			return default(bool);
		}

		public int GetHashCode(CancellationToken obj)
		{
			return default(int);
		}
	}
}
