using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Authentication
{
	public sealed class Digest
	{
		public Uri Uri
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

		public AuthenticationTypes Type
		{
			[CompilerGenerated]
			get
			{
				return default(AuthenticationTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Realm
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

		public bool Stale
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

		private string Nonce
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

		private string Opaque
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

		private string Algorithm
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

		public List<string> ProtectedUris
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

		private string QualityOfProtections
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

		private int NonceCount
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

		private string HA1Sess
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

		internal Digest(Uri uri)
		{
		}

		public void ParseChallange(string header)
		{
		}

		public string GenerateResponseHeader(HTTPRequest request, Credentials credentials, bool isProxy = false)
		{
			return null;
		}

		public bool IsUriProtected(Uri uri)
		{
			return default(bool);
		}
	}
}
