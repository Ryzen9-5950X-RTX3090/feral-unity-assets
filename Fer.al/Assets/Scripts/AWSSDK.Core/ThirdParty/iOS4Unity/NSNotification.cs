using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity
{
	public class NSNotification : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public NSObject Object
		{
			get
			{
				return null;
			}
		}

		static NSNotification()
		{
		}

		public static NSNotification FromName(string name, [Optional] NSObject obj)
		{
			return null;
		}

		internal NSNotification(IntPtr handle)
		{
		}
	}
}
