using System;
using System.Collections.Generic;
using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class HIDTouchpad : HIDControllerElement
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		internal class TouchpadInfo
		{
			public int maxTouches;

			public int minX;

			public int maxX;

			public int minY;

			public int maxY;

			public bool invertY;

			public bool reverseY;

			public TouchpadInfo(int maxTouches, int minX, int maxX, int minY, int maxY, bool invertY, bool reverseY)
			{
			}

			public void CalculateTouch(ref TouchData data)
			{
			}
		}

		[CustomClassObfuscation]
		[CustomObfuscation]
		internal struct TouchData
		{
			public int touchId;

			public float timeStamp;

			public bool isTouching;

			public int positionRawX;

			public int positionRawY;

			public float positionX;

			public float positionY;

			public int positionAbsX;

			public int positionAbsY;

			public void Clear()
			{
			}
		}

		private TouchpadInfo GBluTNNcQBtQoTXZVzOQZAmhzh;

		private Queue<TouchData> GsszQXQGwmfqfgIvEraNKFGmkfA;

		private TouchData[] fyGBMrkPBiRFscYVITjZlMMNmwpX;

		private Action<NativeBuffer, TouchData[]> PDRBnHNQdiYApABXTHhIWvbNQyR;

		public TouchData[] values;

		public HIDTouchpad(byte reportId, TouchpadInfo info, HIDInfo hidInfo, Action<NativeBuffer, TouchData[]> calcValueDelegate)
		{
		}

		public override void UpdateValue(NativeBuffer inputReport, float timestamp)
		{
		}

		public void ProcessQueue()
		{
		}

		public bool IsTouching(int touchId)
		{
			return default(bool);
		}
	}
}
