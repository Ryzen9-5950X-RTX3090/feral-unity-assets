using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleWithWebIdentityResponse : AmazonWebServiceResponse
	{
		private AssumedRoleUser _assumedRoleUser;

		private string _audience;

		private Credentials _credentials;

		private int? _packedPolicySize;

		private string _provider;

		private string _subjectFromWebIdentityToken;

		public AssumedRoleUser AssumedRoleUser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Audience
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public string Provider
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
		public string SubjectFromWebIdentityToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAssumedRoleUser()
		{
			return default(bool);
		}

		internal bool IsSetAudience()
		{
			return default(bool);
		}

		internal bool IsSetCredentials()
		{
			return default(bool);
		}

		internal bool IsSetPackedPolicySize()
		{
			return default(bool);
		}

		internal bool IsSetProvider()
		{
			return default(bool);
		}

		internal bool IsSetSubjectFromWebIdentityToken()
		{
			return default(bool);
		}
	}
}
