using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.Internal
{
	public sealed class UnityRequest : IHttpRequest<string>, IDisposable, IUnityHttpRequest
	{
		private bool _disposed;

		public Uri RequestUri
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

		public IDisposable WwwRequest
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

		public byte[] RequestContent
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

		public Dictionary<string, string> Headers
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

		public AsyncCallback Callback
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

		public IAsyncResult AsyncResult
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

		public ManualResetEvent WaitHandle
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

		public bool IsSync
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

		public IWebResponseData Response
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

		public Exception Exception
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

		public string Method
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

		private StreamReadTracker Tracker
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

		public UnityRequest(Uri requestUri)
		{
		}

		public void ConfigureRequest(IRequestContext requestContext)
		{
		}

		public void SetRequestHeaders(IDictionary<string, string> headers)
		{
		}

		public string GetRequestContent()
		{
			return null;
		}

		public IWebResponseData GetResponse()
		{
			return null;
		}

		public void WriteToRequestBody(string requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
		{
		}

		public void WriteToRequestBody(string requestContent, byte[] content, IDictionary<string, string> contentHeaders)
		{
		}

		public void Abort()
		{
		}

		public IAsyncResult BeginGetRequestContent(AsyncCallback callback, object state)
		{
			return null;
		}

		public string EndGetRequestContent(IAsyncResult asyncResult)
		{
			return null;
		}

		public IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return null;
		}

		public IWebResponseData EndGetResponse(IAsyncResult asyncResult)
		{
			return null;
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
		{
			return null;
		}

		public void OnUploadProgressChanged(float progress)
		{
		}
	}
}
