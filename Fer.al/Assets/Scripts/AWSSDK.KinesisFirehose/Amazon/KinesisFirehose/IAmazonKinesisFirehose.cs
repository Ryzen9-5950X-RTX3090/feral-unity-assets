using System;
using System.Runtime.InteropServices;
using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;

namespace Amazon.KinesisFirehose
{
	public interface IAmazonKinesisFirehose : IAmazonService, IDisposable
	{
		void PutRecordAsync(PutRecordRequest request, AmazonServiceCallback<PutRecordRequest, PutRecordResponse> callback, [Optional] AsyncOptions options);
	}
}
