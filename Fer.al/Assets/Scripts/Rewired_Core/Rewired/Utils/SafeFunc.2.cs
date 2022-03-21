using System;

namespace Rewired.Utils
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class SafeFunc<T, TResult> : SafeDelegate<Func<T, TResult>>
	{
		private T TlDguKccNAoLJIGHCRDccVerjIaM;

		private TResult GzQCfFvbKgfaLkhUNswDRjHQSqD;

		private static Action<object, Func<T, TResult>> JCphBFhoPEtHfyRCzKJoRxrLskc;

		private static Action<object, Func<T, TResult>> invokeDelegate
		{
			get
			{
				return null;
			}
		}

		public SafeFunc()
		{
		}

		public SafeFunc(Action<Exception> exceptionHandler)
		{
		}

		protected SafeFunc(SafeFunc<T, TResult> source)
		{
		}

		public TResult Invoke(T arg0)
		{
			return (TResult)null;
		}

		public override object Clone()
		{
			return null;
		}

		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object P_0, Func<T, TResult> P_1)
		{
		}

		public static SafeFunc<T, TResult>operator +(SafeFunc<T, TResult> eventList, Func<T, TResult> func)
		{
			return null;
		}

		public static SafeFunc<T, TResult>operator -(SafeFunc<T, TResult> eventList, Func<T, TResult> func)
		{
			return null;
		}

		public static implicit operator Func<T, TResult>(SafeFunc<T, TResult> obj)
		{
			return null;
		}

		public static implicit operator SafeFunc<T, TResult>(Func<T, TResult> obj)
		{
			return null;
		}
	}
}
