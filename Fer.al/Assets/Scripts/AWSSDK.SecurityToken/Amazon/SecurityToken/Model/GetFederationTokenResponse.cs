using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class GetFederationTokenResponse : AmazonWebServiceResponse
	{
		private Credentials _credentials;

		private FederatedUser _federatedUser;

		private int? _packedPolicySize;

		public Credentials Credentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FederatedUser FederatedUser
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
		public int PackedPolicySize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal bool IsSetCredentials()
		{
			return default(bool);
		}

		internal bool IsSetFederatedUser()
		{
			return default(bool);
		}

		internal bool IsSetPackedPolicySize()
		{
			return default(bool);
		}
	}
}
