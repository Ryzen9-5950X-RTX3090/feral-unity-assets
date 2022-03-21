namespace WW.iOS.Xcode.PBX
{
	internal class PBXGUID
	{
		internal delegate string GuidGenerator();

		private static GuidGenerator guidGenerator;

		internal static string DefaultGuidGenerator()
		{
			return null;
		}

		internal static void SetGuidGenerator(GuidGenerator generator)
		{
		}

		public static string Generate()
		{
			return null;
		}
	}
}
