using System;

namespace ThirdParty.iOS4Unity
{
	public class NSDictionary : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public virtual NSObject this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint Count
		{
			get
			{
				return default(uint);
			}
		}

		public string[] Keys
		{
			get
			{
				return null;
			}
		}

		public NSObject[] Values
		{
			get
			{
				return null;
			}
		}

		static NSDictionary()
		{
		}

		internal NSDictionary(IntPtr handle)
		{
		}

		public NSDictionary()
		{
		}

		public static NSDictionary FromDictionary(NSDictionary dictionary)
		{
			return null;
		}

		public static NSDictionary FromObjectAndKey(NSObject obj, string key)
		{
			return null;
		}

		public static NSDictionary FromObjectsAndKeys(NSObject[] objs, string[] keys)
		{
			return null;
		}

		public NSObject ObjectForKey(string key)
		{
			return null;
		}

		public NSObject[] ObjectsForKeys(string[] keys)
		{
			return null;
		}

		public string[] KeysForObject(NSObject obj)
		{
			return null;
		}

		public static NSDictionary FromFile(string path)
		{
			return null;
		}

		public bool ContainsKey(string key)
		{
			return default(bool);
		}
	}
}
