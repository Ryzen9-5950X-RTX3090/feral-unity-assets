using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime
{
	public class WebServiceExceptionEventArgs : ExceptionEventArgs
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

		public IDictionary<string, string> Parameters
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

		public string ServiceName
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

		public Uri Endpoint
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

		public Exception Exception
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

		protected WebServiceExceptionEventArgs()
		{
		}

		internal static WebServiceExceptionEventArgs Create(Exception exception, IRequest request)
		{
			return null;
		}
	}
}
