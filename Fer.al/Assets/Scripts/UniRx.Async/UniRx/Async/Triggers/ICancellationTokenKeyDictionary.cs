using System.Threading;

namespace UniRx.Async.Triggers
{
	public interface ICancellationTokenKeyDictionary
	{
		void Remove(CancellationToken token);
	}
}
