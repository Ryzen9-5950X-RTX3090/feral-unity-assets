using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum ScriptingAPILevel
	{
		Net20,
		Net20Subset,
		Net46,
		NetStandard20
	}
}
