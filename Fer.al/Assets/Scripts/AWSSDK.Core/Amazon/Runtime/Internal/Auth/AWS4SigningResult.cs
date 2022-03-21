using System;

namespace Amazon.Runtime.Internal.Auth
{
	public class AWS4SigningResult
	{
		private readonly string _awsAccessKeyId;

		private readonly DateTime _originalDateTime;

		private readonly string _signedHeaders;

		private readonly string _scope;

		private readonly byte[] _signingKey;

		private readonly byte[] _signature;

		public string AccessKeyId
		{
			get
			{
				return null;
			}
		}

		public string ISO8601DateTime
		{
			get
			{
				return null;
			}
		}

		public string ISO8601Date
		{
			get
			{
				return null;
			}
		}

		public string SignedHeaders
		{
			get
			{
				return null;
			}
		}

		public string Scope
		{
			get
			{
				return null;
			}
		}

		public byte[] SigningKey
		{
			get
			{
				return null;
			}
		}

		public string Signature
		{
			get
			{
				return null;
			}
		}

		public byte[] SignatureBytes
		{
			get
			{
				return null;
			}
		}

		public string ForAuthorizationHeader
		{
			get
			{
				return null;
			}
		}

		public string ForQueryParameters
		{
			get
			{
				return null;
			}
		}

		public AWS4SigningResult(string awsAccessKeyId, DateTime signedAt, string signedHeaders, string scope, byte[] signingKey, byte[] signature)
		{
		}
	}
}
