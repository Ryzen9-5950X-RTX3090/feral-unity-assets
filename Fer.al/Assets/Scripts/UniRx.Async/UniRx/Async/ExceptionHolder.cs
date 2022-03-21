using System.Runtime.ExceptionServices;

namespace UniRx.Async
{
	internal class ExceptionHolder
	{
		private ExceptionDispatchInfo exception;

		private bool calledGet;

		public ExceptionHolder(ExceptionDispatchInfo exception)
		{
		}

		public ExceptionDispatchInfo GetException()
		{
			return null;
		}

		~ExceptionHolder()
		{
		}
	}
}
