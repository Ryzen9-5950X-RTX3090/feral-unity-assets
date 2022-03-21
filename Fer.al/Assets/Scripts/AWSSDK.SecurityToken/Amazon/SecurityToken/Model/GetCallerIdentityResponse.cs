using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class GetCallerIdentityResponse : AmazonWebServiceResponse
	{
		private string _account;

		private string _arn;

		private string _userId;

		public string Account
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
		public string Arn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccount()
		{
			return default(bool);
		}

		internal bool IsSetArn()
		{
			return default(bool);
		}

		internal bool IsSetUserId()
		{
			return default(bool);
		}
	}
}
