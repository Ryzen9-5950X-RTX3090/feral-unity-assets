using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Crosstales.Common.Util
{
	public class CTWebClient : WebClient
	{
		public int Timeout
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

		public int ConnectionLimit
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

		public CTWebClient()
		{
		}

		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
}
