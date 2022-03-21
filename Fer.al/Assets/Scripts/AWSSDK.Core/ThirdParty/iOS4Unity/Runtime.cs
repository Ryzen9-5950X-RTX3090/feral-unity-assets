using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
	public static class Runtime
	{
		private static object _contructorLock;

		private static object _objectLock;

		private static readonly Dictionary<Type, Func<IntPtr, object>> _constructors;

		private static readonly Dictionary<IntPtr, object> _objects;

		public static void RegisterType<T>(Func<IntPtr, object> constructor) where T : NSObject
		{
		}

		public static T GetNSObject<T>(IntPtr handle) where T : NSObject
		{
			return null;
		}

		private static T ConstructNSObject<T>(IntPtr handle) where T : NSObject
		{
			return null;
		}

		public static void RegisterNSObject(NSObject obj)
		{
		}

		public static void UnregisterNSObject(IntPtr handle)
		{
		}
	}
}
