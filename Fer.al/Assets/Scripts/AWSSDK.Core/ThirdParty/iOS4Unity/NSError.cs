using System;

namespace ThirdParty.iOS4Unity
{
	public class NSError : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public int Code
		{
			get
			{
				return default(int);
			}
		}

		public string Domain
		{
			get
			{
				return null;
			}
		}

		public string LocalizedDescription
		{
			get
			{
				return null;
			}
		}

		static NSError()
		{
		}

		public NSError(string domain, int code)
		{
		}

		internal NSError(IntPtr handle)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
