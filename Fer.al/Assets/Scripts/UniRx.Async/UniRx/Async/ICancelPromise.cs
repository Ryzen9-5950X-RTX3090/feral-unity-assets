namespace UniRx.Async
{
	public interface ICancelPromise
	{
		bool TrySetCanceled();
	}
}
