using Rewired.Data;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal abstract class PlatformInitializer
	{
		public abstract object Initialize(ConfigVars configVars);

		public abstract IElementIdentifierTool CreateTool(string inputSourceString);
	}
}
