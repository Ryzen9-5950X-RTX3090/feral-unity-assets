using System;

namespace Rewired.Utils
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class SafeAction<T> : SafeDelegate<Action<T>>
	{
		private T TlDguKccNAoLJIGHCRDccVerjIaM;

		private static Action<object, Action<T>> JCphBFhoPEtHfyRCzKJoRxrLskc;

		private static Action<object, Action<T>> invokeDelegate
		{
			get
			{
				return null;
			}
		}

		public SafeAction()
		{
		}

		public SafeAction(Action<Exception> exceptionHandler)
		{
		}

		protected SafeAction(SafeAction<T> source)
		{
		}

		public void Invoke(T arg0)
		{
		}

		public override object Clone()
		{
			return null;
		}

		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object P_0, Action<T> P_1)
		{
		}

		public static SafeAction<T>operator +(SafeAction<T> eventList, Action<T> listener)
		{
			return null;
		}

		public static SafeAction<T>operator -(SafeAction<T> eventList, Action<T> listener)
		{
			return null;
		}

		public static implicit operator Action<T>(SafeAction<T> obj)
		{
			return null;
		}

		public static implicit operator SafeAction<T>(Action<T> obj)
		{
			return null;
		}
	}
}
