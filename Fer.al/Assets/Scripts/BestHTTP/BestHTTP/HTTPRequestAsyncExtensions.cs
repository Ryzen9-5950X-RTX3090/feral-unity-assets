using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace BestHTTP
{
	public static class HTTPRequestAsyncExtensions
	{
		public static Task<HTTPResponse> GetHTTPResponseAsync(this HTTPRequest request, [Optional] CancellationToken token)
		{
			return null;
		}

		public static Task<string> GetAsStringAsync(this HTTPRequest request, [Optional] CancellationToken token)
		{
			return null;
		}

		public static Task<Texture2D> GetAsTexture2DAsync(this HTTPRequest request, [Optional] CancellationToken token)
		{
			return null;
		}

		public static Task<byte[]> GetRawDataAsync(this HTTPRequest request, [Optional] CancellationToken token)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Task<T> CreateTask<T>(HTTPRequest request, CancellationToken token, Action<HTTPRequest, HTTPResponse, TaskCompletionSource<T>> callback)
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VerboseLogging(HTTPRequest request, string str)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Exception CreateException(string errorMessage, [Optional] HTTPResponse resp, [Optional] Exception ex)
		{
			return null;
		}
	}
}
