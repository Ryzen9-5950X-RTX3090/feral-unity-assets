using System;

namespace ThirdParty.iOS4Unity
{
	public class NSObject : IDisposable
	{
		private static readonly IntPtr _classHandle;

		public IntPtr Handle;

		private readonly bool _shouldRelease;

		public virtual IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
		}

		static NSObject()
		{
		}

		~NSObject()
		{
		}

		public NSObject(IntPtr handle)
		{
		}

		public NSObject()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public virtual void Dispose()
		{
		}
	}
}
