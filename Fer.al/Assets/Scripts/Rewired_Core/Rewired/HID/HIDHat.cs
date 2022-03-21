using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class HIDHat : HIDControllerElement
	{
		[CustomObfuscation]
		public enum Type
		{
			ABeAWOemtDNDbkuEcBndYTrwdsCb,
			fgdzdTPVbORjFIfFuGrChHZLMlg
		}

		public int rawValue;

		public float timestamp;

		public readonly int byteLength;

		public readonly int startIndex;

		public readonly Type type;

		private Func<int, int> PDRBnHNQdiYApABXTHhIWvbNQyR;

		public HIDHat(byte reportId, HIDInfo hidInfo, Type type)
		{
		}

		public HIDHat(byte reportId, HIDInfo hidInfo, Func<int, int> calcValueDelegate)
		{
		}

		public override void UpdateValue(NativeBuffer inputReport, float timestamp)
		{
		}
	}
}
