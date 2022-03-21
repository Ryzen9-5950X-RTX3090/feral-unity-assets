namespace UniRx.Async
{
	public interface IResolvePromise<T>
	{
		bool TrySetResult(T value);
	}
}
