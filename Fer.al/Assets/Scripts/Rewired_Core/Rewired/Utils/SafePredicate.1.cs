using System;

namespace Rewired.Utils
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class SafePredicate<T> : SafeDelegate<Predicate<T>>
	{
		private T TlDguKccNAoLJIGHCRDccVerjIaM;

		private bool GzQCfFvbKgfaLkhUNswDRjHQSqD;

		private static Action<object, Predicate<T>> JCphBFhoPEtHfyRCzKJoRxrLskc;

		private static Action<object, Predicate<T>> invokeDelegate
		{
			get
			{
				return null;
			}
		}

		public SafePredicate()
		{
		}

		public SafePredicate(Action<Exception> exceptionHandler)
		{
		}

		protected SafePredicate(SafePredicate<T> source)
		{
		}

		public bool Invoke(T arg0)
		{
			return default(bool);
		}

		public override object Clone()
		{
			return null;
		}

		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object P_0, Predicate<T> P_1)
		{
		}

		public static SafePredicate<T>operator +(SafePredicate<T> eventList, Predicate<T> predicate)
		{
			return null;
		}

		public static SafePredicate<T>operator -(SafePredicate<T> eventList, Predicate<T> predicate)
		{
			return null;
		}

		public static implicit operator Predicate<T>(SafePredicate<T> obj)
		{
			return null;
		}

		public static implicit operator SafePredicate<T>(Predicate<T> obj)
		{
			return null;
		}
	}
}
