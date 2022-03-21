using System.Runtime.CompilerServices;

namespace UniRx.Async
{
	public interface IAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		AwaiterStatus Status { get; }

		bool IsCompleted { get; }

		void GetResult();
	}
}
