using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class ImmutableCredentials
	{
		public string AccessKey
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

		public string SecretKey
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

		public string Token
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

		public bool UseToken
		{
			get
			{
				return default(bool);
			}
		}

		public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
		{
		}

		private ImmutableCredentials()
		{
		}

		public virtual ImmutableCredentials Copy()
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
