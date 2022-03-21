using System;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Authentication;

namespace BestHTTP
{
	public sealed class HTTPProxy : Proxy
	{
		public bool IsTransparent
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

		public bool SendWholeUri
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

		public bool NonTransparentForHTTPS
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

		public HTTPProxy(Uri address)
		{
		}

		public HTTPProxy(Uri address, Credentials credentials)
		{
		}

		public HTTPProxy(Uri address, Credentials credentials, bool isTransparent)
		{
		}

		public HTTPProxy(Uri address, Credentials credentials, bool isTransparent, bool sendWholeUri)
		{
		}

		public HTTPProxy(Uri address, Credentials credentials, bool isTransparent, bool sendWholeUri, bool nonTransparentForHTTPS)
		{
		}

		internal override string GetRequestPath(Uri uri)
		{
			return null;
		}

		internal override void Connect(Stream stream, HTTPRequest request)
		{
		}
	}
}
