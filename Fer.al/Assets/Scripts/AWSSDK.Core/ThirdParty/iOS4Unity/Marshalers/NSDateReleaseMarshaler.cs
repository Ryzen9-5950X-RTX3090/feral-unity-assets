using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity.Marshalers
{
	public class NSDateReleaseMarshaler : NSDateMarshaler
	{
		private static readonly NSDateReleaseMarshaler _instance;

		public new static ICustomMarshaler GetInstance(string cookie)
		{
			return null;
		}

		public override void CleanUpNativeData(IntPtr pNativeData)
		{
		}
	}
}
