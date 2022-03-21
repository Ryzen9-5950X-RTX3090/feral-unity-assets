using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Authentication;

namespace BestHTTP
{
	public abstract class Proxy
	{
		public Uri Address
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

		public List<string> Exceptions
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

		internal Proxy(Uri address, Credentials credentials)
		{
		}

		internal abstract void Connect(Stream stream, HTTPRequest request);

		internal abstract string GetRequestPath(Uri uri);

		internal bool UseProxyForAddress(Uri address)
		{
			return default(bool);
		}
	}
}
