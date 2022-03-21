using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class RequestContext : IRequestContext
	{
		private IServiceMetadata _serviceMetadata;

		private AbstractAWSSigner clientSigner;

		public IRequest Request
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RequestMetrics Metrics
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

		public IClientConfig ClientConfig
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Retries
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CapacityManager.CapacityType LastCapacityType
		{
			[CompilerGenerated]
			get
			{
				return default(CapacityManager.CapacityType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int EndpointDiscoveryRetries
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsSigned
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsAsync
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AmazonWebServiceRequest OriginalRequest
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IMarshaller<IRequest, AmazonWebServiceRequest> Marshaller
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ResponseUnmarshaller Unmarshaller
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public InvokeOptionsBase Options
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ImmutableCredentials ImmutableCredentials
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AbstractAWSSigner Signer
		{
			get
			{
				return null;
			}
		}

		public string RequestName
		{
			get
			{
				return null;
			}
		}

		public IServiceMetadata ServiceMetaData
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool CSMEnabled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsLastExceptionRetryable
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RequestContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}
	}
}
