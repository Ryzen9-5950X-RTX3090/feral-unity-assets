using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
	public class PutRecordRequest : AmazonKinesisFirehoseRequest
	{
		private string _deliveryStreamName;

		private Record _record;

		[AWSProperty]
		public string DeliveryStreamName
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
		public Record Record
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDeliveryStreamName()
		{
			return default(bool);
		}

		internal bool IsSetRecord()
		{
			return default(bool);
		}
	}
}
