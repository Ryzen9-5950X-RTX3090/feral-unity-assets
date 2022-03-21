using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public class AssumeRoleAWSCredentials : RefreshingAWSCredentials
	{
		private RegionEndpoint DefaultSTSClientRegion;

		private Logger _logger;

		public AWSCredentials SourceCredentials
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

		public string RoleArn
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

		public string RoleSessionName
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

		public AssumeRoleAWSCredentialsOptions Options
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

		public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName)
		{
		}

		public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
		{
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}
	}
}
