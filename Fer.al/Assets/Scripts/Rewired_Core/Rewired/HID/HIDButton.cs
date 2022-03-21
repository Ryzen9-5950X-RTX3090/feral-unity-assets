using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class HIDButton : HIDControllerElement
	{
		public bool rawValue;

		public float timestamp;

		public HIDButton(byte reportId, HIDInfo hidInfo)
		{
		}

		public void SetValue(bool rawValue, float timestamp)
		{
		}

		public override void UpdateValue(NativeBuffer inputReport, float timestamp)
		{
		}
	}
}
