using System;
using System.Runtime.CompilerServices;
using BestHTTP.Cookies;

namespace BestHTTP.SignalR.Authentication
{
	public sealed class SampleCookieAuthentication : IAuthenticationProvider
	{
		private HTTPRequest AuthRequest;

		private Cookie Cookie;

		public Uri AuthUri
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

		public string UserName
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

		public string Password
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

		public string UserRoles
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

		public bool IsPreAuthRequired
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

		public event OnAuthenticationSuccededDelegate OnAuthenticationSucceded
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

		public event OnAuthenticationFailedDelegate OnAuthenticationFailed
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

		public SampleCookieAuthentication(Uri authUri, string user, string passwd, string roles)
		{
		}

		public void StartAuthentication()
		{
		}

		public void PrepareRequest(HTTPRequest request, RequestTypes type)
		{
		}

		private void OnAuthRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}
	}
}
