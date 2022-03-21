using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace UniRx.Async.Triggers
{
	public class AsyncTriggerPromiseDictionary<TPromiseType> : Dictionary<CancellationToken, AsyncTriggerPromise<TPromiseType>>, ICancellationTokenKeyDictionary, IEnumerable<ICancelablePromise>, IEnumerable
	{
		IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator()
		{
			return null;
		}

		void ICancellationTokenKeyDictionary.Remove(CancellationToken token)
		{
		}
	}
}
