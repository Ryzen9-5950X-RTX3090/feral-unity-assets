using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity.Marshalers
{
	public class NSStringReleaseMarshaler : NSStringMarshaler
	{
		private static readonly NSStringReleaseMarshaler _instance;

		public new static ICustomMarshaler GetInstance(string cookie)
		{
			return null;
		}

		public override void CleanUpNativeData(IntPtr pNativeData)
		{
		}
	}
}
