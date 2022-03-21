using System;

namespace Amazon.Runtime.Internal
{
	public sealed class UnityWebRequestFactory : IHttpRequestFactory<string>, IDisposable
	{
		private UnityRequest _unityRequest;

		public IHttpRequest<string> CreateHttpRequest(Uri requestUri)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
