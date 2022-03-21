using System.Runtime.CompilerServices;

namespace BestHTTP.Core
{
	[IsReadOnly]
	public struct ProtocolEventInfo
	{
		public readonly IProtocol Source;

		public ProtocolEventInfo(IProtocol source)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
