using System;

namespace Rewired.HID
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal struct OutputReport
	{
		public int reportId;

		public IntPtr buffer;

		public int bufferLength;

		public int reportLength;

		public OutputReportOptions options;

		public bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public OutputReport(IntPtr buffer, int bufferLength, int reportLength)
		{
		}

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
