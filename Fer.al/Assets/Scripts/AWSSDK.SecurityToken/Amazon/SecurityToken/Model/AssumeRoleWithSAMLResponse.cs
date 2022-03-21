using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleWithSAMLResponse : AmazonWebServiceResponse
	{
		private AssumedRoleUser _assumedRoleUser;

		private string _audience;

		private Credentials _credentials;

		private string _issuer;

		private string _nameQualifier;

		private int? _packedPolicySize;

		private string _subject;

		private string _subjectType;

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

		public string Issuer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NameQualifier
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

		public string Subject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SubjectType
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

		internal bool IsSetIssuer()
		{
			return default(bool);
		}

		internal bool IsSetNameQualifier()
		{
			return default(bool);
		}

		internal bool IsSetPackedPolicySize()
		{
			return default(bool);
		}

		internal bool IsSetSubject()
		{
			return default(bool);
		}

		internal bool IsSetSubjectType()
		{
			return default(bool);
		}
	}
}
