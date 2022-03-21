using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.SignalRCore.Messages
{
	public sealed class SupportedTransport
	{
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<string> SupportedFormats
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal SupportedTransport(string transportName, List<string> transferFormats)
		{
		}
	}
}
