namespace UniRx.Async
{
	public interface IPromise<T> : IResolvePromise<T>, IRejectPromise, ICancelPromise
	{
	}
}
