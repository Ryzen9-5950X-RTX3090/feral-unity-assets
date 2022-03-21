using System;

namespace ThirdParty.iOS4Unity
{
	public class NSMutableDictionary : NSDictionary
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public override NSObject this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		static NSMutableDictionary()
		{
		}

		internal NSMutableDictionary(IntPtr handle)
		{
		}

		public NSMutableDictionary()
		{
		}

		public new static NSMutableDictionary FromDictionary(NSDictionary dictionary)
		{
			return null;
		}

		public new static NSMutableDictionary FromObjectAndKey(NSObject obj, string key)
		{
			return null;
		}

		public new static NSMutableDictionary FromObjectsAndKeys(NSObject[] objects, string[] keys)
		{
			return null;
		}

		public void SetObjectForKey(NSObject obj, string key)
		{
		}

		public void RemoveObjectForKey(string key)
		{
		}

		public new static NSMutableDictionary FromFile(string path)
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
