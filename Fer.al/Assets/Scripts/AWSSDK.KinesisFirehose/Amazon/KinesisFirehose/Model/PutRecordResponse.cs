using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
	public class PutRecordResponse : AmazonWebServiceResponse
	{
		private bool? _encrypted;

		private string _recordId;

		public bool Encrypted
		{
			set
			{
			}
		}

		[AWSProperty]
		public string RecordId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
