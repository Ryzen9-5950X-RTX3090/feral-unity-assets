using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class HIDAccelerometer : HIDControllerElement
	{
		public readonly float[] rawValue;

		public float timestamp;

		public readonly int valueLength;

		private readonly byte[] wuZPrKFhqfAdgfTBtloBkqjVrylu;

		private readonly int vUlXhrGGqPAoBatyhmmMclfytPX;

		private readonly int hKTyGPOfFdpmnBQRnpBRLEKDhlKk;

		private readonly Action<byte[], float[]> PDRBnHNQdiYApABXTHhIWvbNQyR;

		public HIDAccelerometer(byte reportId, HIDInfo hidInfo, int valueLength, Action<byte[], float[]> calcValueDelegate)
		{
		}

		public override void UpdateValue(NativeBuffer inputReport, float timestamp)
		{
		}
	}
}
