using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity
{
	public sealed class NSNotificationCenter : NSObject
	{
		private class Observer : NSObject
		{
			private static readonly IntPtr _classHandle;

			public readonly Action<NSNotification> Action;

			public override IntPtr ClassHandle
			{
				get
				{
					return default(IntPtr);
				}
			}

			static Observer()
			{
			}

			public Observer(Action<NSNotification> action)
			{
			}

			public override void Dispose()
			{
			}
		}

		private const string SelectorName = "__onNotification:";

		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public static NSNotificationCenter DefaultCenter
		{
			get
			{
				return null;
			}
		}

		static NSNotificationCenter()
		{
		}

		internal NSNotificationCenter(IntPtr handle)
		{
		}

		public NSObject AddObserver(string name, Action<NSNotification> action, [Optional] NSObject fromObject)
		{
			return null;
		}

		public void PostNotificationName(string name, [Optional] NSObject obj)
		{
		}

		public void RemoveObserver(NSObject observer)
		{
		}
	}
}
