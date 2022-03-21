using System.Runtime.InteropServices;

namespace BestHTTP.SignalRCore.Messages
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct CloseMessage
	{
		public MessageTypes type
		{
			get
			{
				return default(MessageTypes);
			}
		}
	}
}
