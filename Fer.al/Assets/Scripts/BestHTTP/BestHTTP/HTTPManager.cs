using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using BestHTTP.Connections.HTTP2;
using BestHTTP.Extensions;
using BestHTTP.Logger;
using BestHTTP.PlatformSupport.FileSystem;
using BestHTTP.PlatformSupport.IL2CPP;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls;
using UnityEngine;

namespace BestHTTP
{
	[Il2CppEagerStaticClassConstruction]
	public static class HTTPManager
	{
		public static HTTP2PluginSettings HTTP2Settings;

		private static byte maxConnectionPerServer;

		private static HeartbeatManager heartbeats;

		private static BestHTTP.Logger.ILogger logger;

		public static TlsClientFactoryDelegate TlsClientFactory;

		public static int SendBufferSize;

		public static int ReceiveBufferSize;

		public static IIOService IOService;

		public static string UserAgent;

		private static bool IsSetupCalled;

		public static byte MaxConnectionPerServer
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public static bool KeepAliveDefaultValue
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

		public static bool IsCachingDisabled
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

		public static TimeSpan MaxConnectionIdleTime
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

		public static bool IsCookiesEnabled
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

		public static uint CookieJarSize
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool EnablePrivateBrowsing
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

		public static TimeSpan ConnectTimeout
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

		public static TimeSpan RequestTimeout
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

		public static Func<string> RootCacheFolderProvider
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

		public static Proxy Proxy
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

		public static HeartbeatManager Heartbeats
		{
			get
			{
				return null;
			}
		}

		public static BestHTTP.Logger.ILogger Logger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ICertificateVerifyer DefaultCertificateVerifyer
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

		public static IClientCredentialsProvider DefaultClientCredentialsProvider
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

		public static bool UseAlternateSSLDefaultValue
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

		public static Func<HTTPRequest, X509Certificate, X509Chain, bool> DefaultCertificationValidator
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

		internal static int MaxPathLength
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

		public static bool IsQuitting
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

		static HTTPManager()
		{
		}

		public static AbstractTlsClient DefaultTlsClientFactory(HTTPRequest request, List<string> protocols)
		{
			return null;
		}

		public static void Setup()
		{
		}

		public static HTTPRequest SendRequest(string url, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		public static HTTPRequest SendRequest(string url, HTTPMethods methodType, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		public static HTTPRequest SendRequest(string url, HTTPMethods methodType, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		public static HTTPRequest SendRequest(string url, HTTPMethods methodType, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		public static HTTPRequest SendRequest(HTTPRequest request)
		{
			return null;
		}

		public static string GetRootCacheFolder()
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod]
		public static void ResetSetup()
		{
		}

		public static void OnUpdate()
		{
		}

		public static void OnQuit()
		{
		}

		public static void AbortAll()
		{
		}
	}
}
