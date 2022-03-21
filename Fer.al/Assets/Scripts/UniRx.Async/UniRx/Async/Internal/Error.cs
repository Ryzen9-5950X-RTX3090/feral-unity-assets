namespace UniRx.Async.Internal
{
	internal static class Error
	{
		public static void ThrowArgumentNullException<T>(T value, string paramName) where T : class
		{
		}

		private static void ThrowArgumentNullExceptionCore(string paramName)
		{
		}

		public static void ThrowArgumentException<T>(string message)
		{
		}

		public static void ThrowNotYetCompleted()
		{
		}

		public static T ThrowNotYetCompleted<T>()
		{
			return (T)null;
		}

		public static void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField) where T : class
		{
		}

		private static void ThrowInvalidOperationExceptionCore(string message)
		{
		}

		public static void ThrowOperationCanceledException()
		{
		}
	}
}
