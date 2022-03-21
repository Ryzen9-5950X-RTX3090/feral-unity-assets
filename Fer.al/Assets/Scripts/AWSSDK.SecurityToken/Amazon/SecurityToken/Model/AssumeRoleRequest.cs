using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _externalId;

		private string _policy;

		private List<PolicyDescriptorType> _policyArns;

		private string _roleArn;

		private string _roleSessionName;

		private string _serialNumber;

		private List<Tag> _tags;

		private string _tokenCode;

		private List<string> _transitiveTagKeys;

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
		public string ExternalId
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
		public List<Tag> Tags
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

		[AWSProperty]
		public List<string> TransitiveTagKeys
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

		internal bool IsSetExternalId()
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

		internal bool IsSetRoleArn()
		{
			return default(bool);
		}

		internal bool IsSetRoleSessionName()
		{
			return default(bool);
		}

		internal bool IsSetSerialNumber()
		{
			return default(bool);
		}

		internal bool IsSetTags()
		{
			return default(bool);
		}

		internal bool IsSetTokenCode()
		{
			return default(bool);
		}

		internal bool IsSetTransitiveTagKeys()
		{
			return default(bool);
		}
	}
}
