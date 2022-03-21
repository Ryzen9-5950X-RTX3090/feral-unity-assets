using System;
using System.Runtime.CompilerServices;

namespace BestHTTP.SignalRCore.Authentication
{
	public sealed class HeaderAuthenticator : IAuthenticationProvider
	{
		private string _credentials;

		public bool IsPreAuthRequired
		{
			get
			{
				return default(bool);
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

		public HeaderAuthenticator(string credentials)
		{
		}

		public void StartAuthentication()
		{
		}

		public void PrepareRequest(HTTPRequest request)
		{
		}

		public Uri PrepareUri(Uri uri)
		{
			return null;
		}

		public void Cancel()
		{
		}
	}
}
