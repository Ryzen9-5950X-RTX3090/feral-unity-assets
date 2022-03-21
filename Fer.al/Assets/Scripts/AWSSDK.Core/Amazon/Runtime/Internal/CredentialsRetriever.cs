using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	public class CredentialsRetriever : PipelineHandler
	{
		protected AWSCredentials Credentials
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

		public CredentialsRetriever(AWSCredentials credentials)
		{
		}

		protected virtual void PreInvoke(IExecutionContext executionContext)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
		{
			return null;
		}
	}
}
