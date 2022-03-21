using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum ScriptingBackend
	{
		Mono,
		DotNet,
		IL2CPP
	}
}
