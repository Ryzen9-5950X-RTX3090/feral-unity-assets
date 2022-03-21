using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class URIBasedRefreshingCredentialHelper : RefreshingAWSCredentials
	{
		protected class SecurityBase
		{
			public string Code
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

			public string Message
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

			public DateTime LastUpdated
			{
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		protected class SecurityInfo : SecurityBase
		{
			public string InstanceProfileArn
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

			public string InstanceProfileId
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
		}

		protected class SecurityCredentials : SecurityBase
		{
			public string Type
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

			public string AccessKeyId
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

			public string SecretAccessKey
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

			public string Token
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

			public DateTime Expiration
			{
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string RoleArn
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
		}

		private static string SuccessCode;

		protected static string GetContents(Uri uri)
		{
			return null;
		}

		protected static string GetContents(Uri uri, IWebProxy proxy)
		{
			return null;
		}

		protected static string GetContents(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
		{
			return null;
		}

		protected static T GetObjectFromResponse<T>(Uri uri)
		{
			return (T)null;
		}

		protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy)
		{
			return (T)null;
		}

		protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
		{
			return (T)null;
		}

		protected static void ValidateResponse(SecurityBase response)
		{
		}
	}
}
