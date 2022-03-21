using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class HeadersRequestEventArgs : RequestEventArgs
	{
		public IDictionary<string, string> Headers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected HeadersRequestEventArgs()
		{
		}

		internal static HeadersRequestEventArgs Create(IDictionary<string, string> headers)
		{
			return null;
		}
	}
}
