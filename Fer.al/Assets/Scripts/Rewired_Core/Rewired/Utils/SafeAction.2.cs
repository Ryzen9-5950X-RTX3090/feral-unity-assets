using System;

namespace Rewired.Utils
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class SafeAction<T, T2> : SafeDelegate<Action<T, T2>>
	{
		private T TlDguKccNAoLJIGHCRDccVerjIaM;

		private T2 oblUDRJNDgDPDYPcAEdpfehHggEH;

		private static Action<object, Action<T, T2>> JCphBFhoPEtHfyRCzKJoRxrLskc;

		private static Action<object, Action<T, T2>> invokeDelegate
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

		protected SafeAction(SafeAction<T, T2> source)
		{
		}

		public void Invoke(T arg0, T2 arg1)
		{
		}

		public override object Clone()
		{
			return null;
		}

		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object P_0, Action<T, T2> P_1)
		{
		}

		public static SafeAction<T, T2>operator +(SafeAction<T, T2> eventList, Action<T, T2> listener)
		{
			return null;
		}

		public static SafeAction<T, T2>operator -(SafeAction<T, T2> eventList, Action<T, T2> listener)
		{
			return null;
		}

		public static implicit operator Action<T, T2>(SafeAction<T, T2> obj)
		{
			return null;
		}

		public static implicit operator SafeAction<T, T2>(Action<T, T2> obj)
		{
			return null;
		}
	}
}
