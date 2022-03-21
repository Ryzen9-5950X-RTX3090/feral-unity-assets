using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class GetSessionTokenRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _serialNumber;

		private string _tokenCode;

		[AWSProperty]
		public int DurationSeconds
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[AWSProperty]
		public string SerialNumber
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
		public string TokenCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDurationSeconds()
		{
			return default(bool);
		}

		internal bool IsSetSerialNumber()
		{
			return default(bool);
		}

		internal bool IsSetTokenCode()
		{
			return default(bool);
		}
	}
}
