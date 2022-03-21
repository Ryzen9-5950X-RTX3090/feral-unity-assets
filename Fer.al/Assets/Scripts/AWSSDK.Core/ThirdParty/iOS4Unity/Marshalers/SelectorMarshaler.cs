using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity.Marshalers
{
	public class SelectorMarshaler : ICustomMarshaler
	{
		private static readonly SelectorMarshaler _instance;

		public static ICustomMarshaler GetInstance(string cookie)
		{
			return null;
		}

		public void CleanUpManagedData(object managedObj)
		{
		}

		public void CleanUpNativeData(IntPtr pNativeData)
		{
		}

		public int GetNativeDataSize()
		{
			return default(int);
		}

		public IntPtr MarshalManagedToNative(object managedObj)
		{
			return default(IntPtr);
		}

		public object MarshalNativeToManaged(IntPtr pNativeData)
		{
			return null;
		}
	}
}
