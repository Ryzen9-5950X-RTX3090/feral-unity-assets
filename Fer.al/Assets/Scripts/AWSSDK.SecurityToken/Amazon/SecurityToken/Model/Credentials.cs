using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class Credentials : AWSCredentials
	{
		private ImmutableCredentials _credentials;

		private string _accessKeyId;

		private DateTime? _expiration;

		private string _secretAccessKey;

		private string _sessionToken;

		[AWSProperty]
		public string AccessKeyId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public DateTime Expiration
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		[AWSProperty]
		public string SecretAccessKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string SessionToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		public Credentials()
		{
		}

		public Credentials(string accessKeyId, string secretAccessKey, string sessionToken, DateTime expiration)
		{
		}

		internal bool IsSetAccessKeyId()
		{
			return default(bool);
		}

		internal bool IsSetExpiration()
		{
			return default(bool);
		}

		internal bool IsSetSecretAccessKey()
		{
			return default(bool);
		}

		internal bool IsSetSessionToken()
		{
			return default(bool);
		}
	}
}
