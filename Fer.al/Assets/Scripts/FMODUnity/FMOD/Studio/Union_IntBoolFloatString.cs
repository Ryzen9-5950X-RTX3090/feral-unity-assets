using System.Runtime.InteropServices;

namespace FMOD.Studio
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct Union_IntBoolFloatString
	{
		public int intvalue;

		public bool boolvalue;

		public float floatvalue;

		public StringWrapper stringvalue;
	}
}
