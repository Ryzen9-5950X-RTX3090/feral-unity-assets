using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public abstract class AmazonServiceClient : IDisposable
	{
		private bool _disposed;

		private Logger _logger;

		[CompilerGenerated]
		private readonly IServiceMetadata <ServiceMetadata>k__BackingField;

		private PreRequestEventHandler mBeforeMarshallingEvent;

		private RequestEventHandler mBeforeRequestEvent;

		private ResponseEventHandler mAfterResponseEvent;

		private ExceptionEventHandler mExceptionEvent;

		protected EndpointDiscoveryResolverBase EndpointDiscoveryResolver
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

		protected RuntimePipeline RuntimePipeline
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

		protected internal AWSCredentials Credentials
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

		public IClientConfig Config
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

		protected virtual IServiceMetadata ServiceMetadata
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected virtual bool SupportResponseLogging
		{
			get
			{
				return default(bool);
			}
		}

		protected AbstractAWSSigner Signer
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

		internal event PreRequestEventHandler BeforeMarshallingEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event RequestEventHandler BeforeRequestEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ResponseEventHandler AfterResponseEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ExceptionEventHandler ExceptionEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		protected AmazonServiceClient(AWSCredentials credentials, ClientConfig config)
		{
		}

		protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
		{
		}

		protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
		{
		}

		protected virtual void Initialize()
		{
		}

		[Obsolete]
		protected TResponse Invoke<TResponse, TRequest>(TRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller) where TResponse : AmazonWebServiceResponse where TRequest : AmazonWebServiceRequest
		{
			return null;
		}

		protected TResponse Invoke<TResponse>(AmazonWebServiceRequest request, InvokeOptionsBase options) where TResponse : AmazonWebServiceResponse
		{
			return null;
		}

		[Obsolete]
		protected IAsyncResult BeginInvoke<TRequest>(TRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller, AsyncOptions asyncOptions, Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper) where TRequest : AmazonWebServiceRequest
		{
			return null;
		}

		protected IAsyncResult BeginInvoke(AmazonWebServiceRequest request, InvokeOptionsBase options, AsyncOptions asyncOptions, Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper)
		{
			return null;
		}

		[Obsolete]
		protected IAsyncResult BeginInvoke<TRequest>(TRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller, AsyncCallback callback, object state) where TRequest : AmazonWebServiceRequest
		{
			return null;
		}

		protected IAsyncResult BeginInvoke(AmazonWebServiceRequest request, InvokeOptionsBase options, AsyncCallback callback, object state)
		{
			return null;
		}

		protected static TResponse EndInvoke<TResponse>(IAsyncResult result) where TResponse : AmazonWebServiceResponse
		{
			return null;
		}

		protected virtual IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
		{
			return null;
		}

		protected void ProcessPreRequestHandlers(IExecutionContext executionContext)
		{
		}

		protected void ProcessRequestHandlers(IExecutionContext executionContext)
		{
		}

		protected void ProcessResponseHandlers(IExecutionContext executionContext)
		{
		}

		protected virtual void ProcessExceptionHandlers(IExecutionContext executionContext, Exception exception)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private void ThrowIfDisposed()
		{
		}

		protected abstract AbstractAWSSigner CreateSigner();

		protected virtual void CustomizeRuntimePipeline(RuntimePipeline pipeline)
		{
		}

		private void BuildRuntimePipeline()
		{
		}

		public static Uri ComposeUrl(IRequest iRequest)
		{
			return null;
		}

		private static void DontUnescapePathDotsAndSlashes(Uri uri)
		{
		}

		internal C CloneConfig<C>() where C : ClientConfig, new()
		{
			return null;
		}

		internal void CloneConfig(ClientConfig newConfig)
		{
		}

		private static void SetupCSMHandler(IRequestContext requestContext)
		{
		}
	}
}
