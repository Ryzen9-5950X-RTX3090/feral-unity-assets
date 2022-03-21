using System;
using Rewired.Config;
using Rewired.Drivers.Interfaces;

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal abstract class HIDDeviceDriver : IDisposable, IControllerDriver
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		internal class InitArgs
		{
			public UpdateLoopSetting updateLoopSetting;

			public DeviceConnectionType connectionType;

			public int minAxisValue;

			public int maxAxisValue;

			public int hatZeroValue;

			public int hatSpan;

			public int inputReportLength;

			public int outputReportLength;

			public Func<OutputReport, bool> synchronousWriteOutputReportDelegate;

			public Action<OutputReport> asynchronousWriteOutputReportDelegate;

			public InitArgs(UpdateLoopSetting updateLoopSetting, DeviceConnectionType connectionType, int minAxisValue, int maxAxisValue, int hatZeroValue, int hatSpan, int inputReportLength, int outputReportLength, Func<OutputReport, bool> synchronousWriteOutputReportDelegate, Action<OutputReport> asynchronousWriteOutputReportDelegate)
			{
			}
		}

		public HIDAxis[] axes;

		public HIDButton[] buttons;

		public HIDHat[] hats;

		public HIDAccelerometer[] accelerometers;

		public HIDGyroscope[] gyroscopes;

		public HIDTouchpad[] touchpads;

		public HIDVibrationMotor[] vibrationMotors;

		public HIDLight[] lights;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public int AxisCount
		{
			get
			{
				return default(int);
			}
		}

		public int ButtonCount
		{
			get
			{
				return default(int);
			}
		}

		public int HatCount
		{
			get
			{
				return default(int);
			}
		}

		public int AccelerometerCount
		{
			get
			{
				return default(int);
			}
		}

		public int GyroscopeCount
		{
			get
			{
				return default(int);
			}
		}

		public int TouchpadCount
		{
			get
			{
				return default(int);
			}
		}

		public int LightCount
		{
			get
			{
				return default(int);
			}
		}

		public int VibrationMotorCount
		{
			get
			{
				return default(int);
			}
		}

		protected bool disposed
		{
			get
			{
				return default(bool);
			}
		}

		public HIDDeviceDriver()
		{
		}

		public abstract void Update(UpdateLoopType updateLoop);

		public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp);

		public abstract Controller.Extension CreateControllerExtension();

		public static HIDDeviceDriver GetDriver(int driverId, InitArgs hidDriverInitArgs)
		{
			return null;
		}

		public static int FindDriverId(int vendorId, int productId)
		{
			return default(int);
		}

		public void Dispose()
		{
		}

		~HIDDeviceDriver()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
