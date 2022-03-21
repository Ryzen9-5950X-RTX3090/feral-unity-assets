using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleWithWebIdentityRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _policy;

		private List<PolicyDescriptorType> _policyArns;

		private string _providerId;

		private string _roleArn;

		private string _roleSessionName;

		private string _webIdentityToken;

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
		public string Policy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<PolicyDescriptorType> PolicyArns
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
		public string ProviderId
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
		public string RoleArn
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
		public string RoleSessionName
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
		public string WebIdentityToken
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

		internal bool IsSetPolicy()
		{
			return default(bool);
		}

		internal bool IsSetPolicyArns()
		{
			return default(bool);
		}

		internal bool IsSetProviderId()
		{
			return default(bool);
		}

		internal bool IsSetRoleArn()
		{
			return default(bool);
		}

		internal bool IsSetRoleSessionName()
		{
			return default(bool);
		}

		internal bool IsSetWebIdentityToken()
		{
			return default(bool);
		}
	}
}
