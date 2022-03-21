using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class GetFederationTokenRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _name;

		private string _policy;

		private List<PolicyDescriptorType> _policyArns;

		private List<Tag> _tags;

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
		public string Name
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

		public GetFederationTokenRequest()
		{
		}

		public GetFederationTokenRequest(string name)
		{
		}

		internal bool IsSetDurationSeconds()
		{
			return default(bool);
		}

		internal bool IsSetName()
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

		internal bool IsSetTags()
		{
			return default(bool);
		}
	}
}
