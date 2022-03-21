using Rewired.Data;
using Rewired.Interfaces;

namespace Rewired.InputManagers
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class Initializer : PlatformInitializer
	{
		private static PlatformInitializer instance;

		public static PlatformInitializer GetPlatformInitializer()
		{
			return null;
		}

		public override object Initialize(ConfigVars configVars)
		{
			return null;
		}

		public override Rewired.Interfaces.IElementIdentifierTool CreateTool(string inputSourceString)
		{
			return null;
		}
	}
}
