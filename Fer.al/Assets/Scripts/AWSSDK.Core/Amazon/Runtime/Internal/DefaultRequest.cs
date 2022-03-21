using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
	public class DefaultRequest : IRequest
	{
		private readonly ParameterCollection parametersCollection;

		private readonly IDictionary<string, string> parametersFacade;

		private readonly IDictionary<string, string> headers;

		private readonly IDictionary<string, string> subResources;

		private readonly IDictionary<string, string> pathResources;

		private Uri endpoint;

		private string resourcePath;

		private string serviceName;

		private readonly AmazonWebServiceRequest originalRequest;

		private byte[] content;

		private Stream contentStream;

		private string contentStreamHash;

		private string httpMethod;

		private bool useQueryString;

		private string requestName;

		private string canonicalResource;

		private RegionEndpoint alternateRegion;

		private long originalStreamLength;

		private int marshallerVersion;

		public string RequestName
		{
			get
			{
				return null;
			}
		}

		public string HttpMethod
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseQueryString
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public AmazonWebServiceRequest OriginalRequest
		{
			get
			{
				return null;
			}
		}

		public IDictionary<string, string> Headers
		{
			get
			{
				return null;
			}
		}

		public IDictionary<string, string> Parameters
		{
			get
			{
				return null;
			}
		}

		public ParameterCollection ParameterCollection
		{
			get
			{
				return null;
			}
		}

		public IDictionary<string, string> SubResources
		{
			get
			{
				return null;
			}
		}

		public Uri Endpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ResourcePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDictionary<string, string> PathResources
		{
			get
			{
				return null;
			}
		}

		public int MarshallerVersion
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public string CanonicalResource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte[] Content
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SetContentFromParameters
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

		public Stream ContentStream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long OriginalStreamPosition
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public string ServiceName
		{
			get
			{
				return null;
			}
		}

		public RegionEndpoint AlternateEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string HostPrefix
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

		public bool Suppress404Exceptions
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

		public AWS4SigningResult AWS4SignerResult
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

		public bool UseChunkEncoding
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

		public string CanonicalResourcePrefix
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

		public bool UseSigV4
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

		public string AuthenticationRegion
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

		public string DeterminedSigningRegion
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

		public DefaultRequest(AmazonWebServiceRequest request, string serviceName)
		{
		}

		public void AddSubResource(string subResource)
		{
		}

		public void AddSubResource(string subResource, string value)
		{
		}

		public void AddPathResource(string key, string value)
		{
		}

		public string ComputeContentStreamHash()
		{
			return null;
		}

		public bool IsRequestStreamRewindable()
		{
			return default(bool);
		}

		public bool MayContainRequestBody()
		{
			return default(bool);
		}

		public bool HasRequestBody()
		{
			return default(bool);
		}

		public string GetHeaderValue(string headerName)
		{
			return null;
		}
	}
}
