using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BestHTTP.Authentication;
using BestHTTP.Connections;
using BestHTTP.Cookies;
using BestHTTP.Forms;
using BestHTTP.Logger;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls;
using BestHTTP.Timings;

namespace BestHTTP
{
	public sealed class HTTPRequest : IEnumerator, IEnumerator<HTTPRequest>, IDisposable
	{
		internal struct UploadStreamInfo
		{
			public readonly Stream Stream;

			public readonly long Length;

			public UploadStreamInfo(Stream stream, long length)
			{
			}
		}

		public static readonly byte[] EOL;

		public static readonly string[] MethodNames;

		public static int UploadChunkSize;

		public OnUploadProgressDelegate OnUploadProgress;

		public OnStreamingDataDelegate OnStreamingData;

		public Action<HTTPRequest, HTTPResponse> OnHeadersReceived;

		public OnDownloadProgressDelegate OnDownloadProgress;

		private List<Cookie> customCookies;

		private HTTPRequestStates _state;

		private OnBeforeRedirectionDelegate onBeforeRedirection;

		private OnBeforeHeaderSendDelegate _onBeforeHeaderSend;

		internal OnRequestFinishedDelegate OnUpgraded;

		internal Action<HTTPRequest> OnCancellationRequested;

		private bool isKeepAlive;

		private bool disableCache;

		private bool cacheOnly;

		private int streamFragmentSize;

		private bool useStreaming;

		private HTTPFormBase FieldCollector;

		private HTTPFormBase FormImpl;

		public Uri Uri
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

		public HTTPMethods MethodType
		{
			[CompilerGenerated]
			get
			{
				return default(HTTPMethods);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public byte[] RawData
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

		public Stream UploadStream
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

		public bool DisposeUploadStream
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

		public bool UseUploadStreamLength
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

		public bool IsKeepAlive
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool DisableCache
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CacheOnly
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int StreamFragmentSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool StreamChunksImmediately
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

		public int ReadBufferSizeOverride
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

		public int MaxFragmentQueueLength
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

		public OnRequestFinishedDelegate Callback
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

		public DateTime QueuedAt
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public bool IsConnectTimedOut
		{
			get
			{
				return default(bool);
			}
		}

		public DateTime ProcessingStarted
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public bool IsTimedOut
		{
			get
			{
				return default(bool);
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
			internal set
			{
			}
		}

		public int MaxRetries
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

		public bool IsCancellationRequested
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public bool IsRedirected
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Uri RedirectUri
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Uri CurrentUri
		{
			get
			{
				return null;
			}
		}

		public HTTPResponse Response
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public HTTPResponse ProxyResponse
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
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
			internal set
			{
			}
		}

		public object Tag
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

		public Credentials Credentials
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

		public bool HasProxy
		{
			get
			{
				return default(bool);
			}
		}

		public Proxy Proxy
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

		public int MaxRedirects
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

		public bool UseAlternateSSL
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

		public bool IsCookiesEnabled
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

		public List<Cookie> Cookies
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HTTPFormUsage FormUsage
		{
			[CompilerGenerated]
			get
			{
				return default(HTTPFormUsage);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HTTPRequestStates State
		{
			get
			{
				return default(HTTPRequestStates);
			}
			internal set
			{
			}
		}

		public int RedirectCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public TimeSpan ConnectTimeout
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeSpan Timeout
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool EnableTimoutForStreaming
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

		public bool EnableSafeReadOnUnknownContentLength
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

		public ICertificateVerifyer CustomCertificateVerifyer
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

		public IClientCredentialsProvider CustomClientCredentialsProvider
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

		public List<string> CustomTLSServerNameList
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

		public LoggingContext Context
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

		public TimingCollector Timing
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

		internal SupportedProtocols ProtocolHandler
		{
			[CompilerGenerated]
			get
			{
				return default(SupportedProtocols);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool UseStreaming
		{
			get
			{
				return default(bool);
			}
		}

		internal long UploadStreamLength
		{
			get
			{
				return default(long);
			}
		}

		private Dictionary<string, List<string>> Headers
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

		public object Current
		{
			get
			{
				return null;
			}
		}

		HTTPRequest IEnumerator<HTTPRequest>.Current
		{
			get
			{
				return null;
			}
		}

		public event Func<HTTPRequest, X509Certificate, X509Chain, bool> CustomCertificationValidator
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnBeforeRedirectionDelegate OnBeforeRedirection
		{
			add
			{
			}
			remove
			{
			}
		}

		public event OnBeforeHeaderSendDelegate OnBeforeHeaderSend
		{
			add
			{
			}
			remove
			{
			}
		}

		public HTTPRequest(Uri uri)
		{
		}

		public HTTPRequest(Uri uri, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
		}

		public HTTPRequest(Uri uri, HTTPMethods methodType, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
		}

		public void AddField(string fieldName, string value)
		{
		}

		public void AddField(string fieldName, string value, Encoding e)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content, string fileName)
		{
		}

		public void AddBinaryData(string fieldName, byte[] content, string fileName, string mimeType)
		{
		}

		public void SetForm(HTTPFormBase form)
		{
		}

		public List<HTTPFieldData> GetFormFields()
		{
			return null;
		}

		public void ClearForm()
		{
		}

		private HTTPFormBase SelectFormImplementation()
		{
			return null;
		}

		public void AddHeader(string name, string value)
		{
		}

		public void SetHeader(string name, string value)
		{
		}

		public bool RemoveHeader(string name)
		{
			return default(bool);
		}

		public bool HasHeader(string name)
		{
			return default(bool);
		}

		public string GetFirstHeaderValue(string name)
		{
			return null;
		}

		public List<string> GetHeaderValues(string name)
		{
			return null;
		}

		public void RemoveHeaders()
		{
		}

		public void SetRangeHeader(long firstBytePos)
		{
		}

		public void SetRangeHeader(long firstBytePos, long lastBytePos)
		{
		}

		public void EnumerateHeaders(OnHeaderEnumerationDelegate callback)
		{
		}

		public void EnumerateHeaders(OnHeaderEnumerationDelegate callback, bool callBeforeSendCallback)
		{
		}

		private void SendHeaders(Stream stream)
		{
		}

		public string DumpHeaders()
		{
			return null;
		}

		public byte[] GetEntityBody()
		{
			return null;
		}

		internal UploadStreamInfo GetUpStream()
		{
			return default(UploadStreamInfo);
		}

		internal void SendOutTo(Stream stream)
		{
		}

		internal void UpgradeCallback()
		{
		}

		internal bool CallOnBeforeRedirection(Uri redirectUri)
		{
			return default(bool);
		}

		internal void Prepare()
		{
		}

		internal bool CallCustomCertificationValidator(X509Certificate cert, X509Chain chain)
		{
			return default(bool);
		}

		public HTTPRequest Send()
		{
			return null;
		}

		public void Abort()
		{
		}

		public void Clear()
		{
		}

		private void VerboseLogging(string str)
		{
		}

		public bool MoveNext()
		{
			return default(bool);
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}
}
