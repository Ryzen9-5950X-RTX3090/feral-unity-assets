using System.Runtime.CompilerServices;

namespace UniRx.Async
{
	public interface IAwaiter<out T> : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
	{
		new T GetResult();
	}
}
