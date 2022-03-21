using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Util;
using UnityEngine;

namespace Amazon.Runtime.Internal.Transform
{
	public sealed class UnityWebResponseData : IWebResponseData, IHttpResponseBody, IDisposable
	{
		private Dictionary<string, string> _headers;

		private string[] _headerNames;

		private HashSet<string> _headerNamesSet;

		private Stream _responseStream;

		private byte[] _responseBody;

		private Amazon.Runtime.Internal.Util.ILogger _logger;

		public long ContentLength
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ContentType
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

		public HttpStatusCode StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(HttpStatusCode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsSuccessStatusCode
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

		public IHttpResponseBody ResponseBody
		{
			get
			{
				return null;
			}
		}

		public bool IsResponseBodyPresent
		{
			get
			{
				return default(bool);
			}
		}

		public UnityWebResponseData(UnityWebRequestWrapper unityWebRequest)
		{
		}

		public UnityWebResponseData(WWW wwwRequest)
		{
		}

		public bool IsHeaderPresent(string headerName)
		{
			return default(bool);
		}

		public string[] GetHeaderNames()
		{
			return null;
		}

		public string GetHeaderValue(string name)
		{
			return null;
		}

		private void CopyHeaderValues(Dictionary<string, string> headers)
		{
		}

		public Stream OpenResponse()
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
