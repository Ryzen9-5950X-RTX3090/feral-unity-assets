using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class AssumeRoleImmutableCredentials : ImmutableCredentials
	{
		public DateTime Expiration
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

		public AssumeRoleImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, DateTime expiration)
		{
		}

		public new AssumeRoleImmutableCredentials Copy()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
