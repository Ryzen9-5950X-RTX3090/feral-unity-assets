using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class SAMLImmutableCredentials : ImmutableCredentials
	{
		private const string AccessKeyProperty = "AccessKey";

		private const string SecretKeyProperty = "SecretKey";

		private const string TokenProperty = "Token";

		private const string ExpiresProperty = "Expires";

		private const string SubjectProperty = "Subject";

		public DateTime Expires
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Subject
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

		public SAMLImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, DateTime expires, string subject)
		{
		}

		public SAMLImmutableCredentials(ImmutableCredentials credentials, DateTime expires, string subject)
		{
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override ImmutableCredentials Copy()
		{
			return null;
		}

		internal string ToJson()
		{
			return null;
		}

		internal static SAMLImmutableCredentials FromJson(string json)
		{
			return null;
		}
	}
}
