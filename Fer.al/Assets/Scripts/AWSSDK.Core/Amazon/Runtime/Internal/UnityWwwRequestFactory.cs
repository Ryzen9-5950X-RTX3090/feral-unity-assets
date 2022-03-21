using System;

namespace Amazon.Runtime.Internal
{
	public sealed class UnityWwwRequestFactory : IHttpRequestFactory<string>, IDisposable
	{
		private UnityWwwRequest _unityWwwRequest;

		public IHttpRequest<string> CreateHttpRequest(Uri requestUri)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
