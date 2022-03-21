using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using UnityEngine;

namespace Amazon.Runtime.Internal
{
	public class UnityWebRequestWrapper : IDisposable
	{
		private static Type unityWebRequestType;

		private static PropertyInfo[] unityWebRequestProperties;

		private static MethodInfo[] unityWebRequestMethods;

		private static MethodInfo setRequestHeaderMethod;

		private static MethodInfo sendMethod;

		private static MethodInfo getResponseHeadersMethod;

		private static MethodInfo isDoneGetMethod;

		private static MethodInfo downloadProgressGetMethod;

		private static MethodInfo uploadProgressGetMethod;

		private static MethodInfo isErrorGetMethod;

		private static MethodInfo downloadedBytesGetMethod;

		private static MethodInfo responseCodeGetMethod;

		private static MethodInfo downloadHandlerSetMethod;

		private static MethodInfo uploadHandlerSetMethod;

		private static MethodInfo errorGetMethod;

		private object unityWebRequestInstance;

		private DownloadHandlerBufferWrapper downloadHandler;

		private UploadHandlerRawWrapper uploadHandler;

		private bool disposedValue;

		internal static bool IsUnityWebRequestSupported
		{
			get
			{
				return default(bool);
			}
		}

		public DownloadHandlerBufferWrapper DownloadHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UploadHandlerRawWrapper UploadHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsDone
		{
			get
			{
				return default(bool);
			}
		}

		public float DownloadProgress
		{
			get
			{
				return default(float);
			}
		}

		public float UploadProgress
		{
			get
			{
				return default(float);
			}
		}

		public ulong DownloadedBytes
		{
			get
			{
				return default(ulong);
			}
		}

		public Dictionary<string, string> ResponseHeaders
		{
			get
			{
				return null;
			}
		}

		public HttpStatusCode? StatusCode
		{
			get
			{
				return null;
			}
		}

		public bool IsError
		{
			get
			{
				return default(bool);
			}
		}

		public string Error
		{
			get
			{
				return null;
			}
		}

		static UnityWebRequestWrapper()
		{
		}

		public UnityWebRequestWrapper()
		{
		}

		public UnityWebRequestWrapper(string url, string method)
		{
		}

		public UnityWebRequestWrapper(string url, string method, DownloadHandlerBufferWrapper downloadHandler, UploadHandlerRawWrapper uploadHandler)
		{
		}

		public void SetRequestHeader(string key, string value)
		{
		}

		public AsyncOperation Send()
		{
			return null;
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
