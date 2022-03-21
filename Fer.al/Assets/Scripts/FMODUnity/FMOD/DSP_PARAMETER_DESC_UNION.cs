using System.Runtime.InteropServices;

namespace FMOD
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DSP_PARAMETER_DESC_UNION
	{
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		public DSP_PARAMETER_DESC_INT intdesc;

		public DSP_PARAMETER_DESC_BOOL booldesc;

		public DSP_PARAMETER_DESC_DATA datadesc;
	}
}
