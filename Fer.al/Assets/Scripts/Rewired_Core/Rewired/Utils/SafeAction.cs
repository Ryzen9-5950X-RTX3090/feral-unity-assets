using System;

namespace Rewired.Utils
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal sealed class SafeAction : SafeDelegate<Action>
	{
		private static Action<object, Action> JCphBFhoPEtHfyRCzKJoRxrLskc;

		private static Action<object, Action> invokeDelegate
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

		private SafeAction(SafeAction source)
		{
		}

		public void Invoke()
		{
		}

		public override object Clone()
		{
			return null;
		}

		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object P_0, Action P_1)
		{
		}

		public static SafeAction operator +(SafeAction eventList, Action listener)
		{
			return null;
		}

		public static SafeAction operator -(SafeAction eventList, Action listener)
		{
			return null;
		}

		public static implicit operator Action(SafeAction obj)
		{
			return null;
		}

		public static implicit operator SafeAction(Action obj)
		{
			return null;
		}
	}
}
