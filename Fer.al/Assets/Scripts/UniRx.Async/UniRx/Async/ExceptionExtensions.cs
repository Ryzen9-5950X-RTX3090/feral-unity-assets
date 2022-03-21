using System;

namespace UniRx.Async
{
	public static class ExceptionExtensions
	{
		public static bool IsOperationCanceledException(this Exception exception)
		{
			return default(bool);
		}
	}
}
