using System.Runtime.CompilerServices;

namespace BestHTTP.Core
{
	[IsReadOnly]
	public struct PluginEventInfo
	{
		public readonly PluginEvents Event;

		public readonly object Payload;

		public PluginEventInfo(PluginEvents @event)
		{
		}

		public PluginEventInfo(PluginEvents @event, object payload)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
