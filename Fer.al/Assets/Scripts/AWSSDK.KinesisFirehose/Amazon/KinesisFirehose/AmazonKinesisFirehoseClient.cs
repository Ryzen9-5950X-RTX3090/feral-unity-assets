using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.KinesisFirehose
{
	public class AmazonKinesisFirehoseClient : AmazonServiceClient, IAmazonKinesisFirehose, IAmazonService, IDisposable
	{
		private static IServiceMetadata serviceMetadata;

		protected override IServiceMetadata ServiceMetadata
		{
			get
			{
				return null;
			}
		}

		public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
		{
		}

		public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisFirehoseConfig clientConfig)
		{
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		public virtual void PutRecordAsync(PutRecordRequest request, AmazonServiceCallback<PutRecordRequest, PutRecordResponse> callback, [Optional] AsyncOptions options)
		{
		}

		[SpecialName]
		IClientConfig IAmazonService.get_Config()
		{
			return null;
		}
	}
}
