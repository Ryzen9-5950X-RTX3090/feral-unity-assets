using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class PreRequestEventArgs : EventArgs
	{
		public AmazonWebServiceRequest Request
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

		protected PreRequestEventArgs()
		{
		}

		internal static PreRequestEventArgs Create(AmazonWebServiceRequest request)
		{
			return null;
		}
	}
}
