using System;

namespace Amazon.Auth.AccessControlPolicy
{
	public static class ConditionFactory
	{
		public enum ArnComparisonType
		{
			ArnEquals,
			ArnLike,
			ArnNotEquals,
			ArnNotLike
		}

		public enum DateComparisonType
		{
			DateEquals,
			DateGreaterThan,
			DateGreaterThanEquals,
			DateLessThan,
			DateLessThanEquals,
			DateNotEquals
		}

		public enum IpAddressComparisonType
		{
			IpAddress,
			NotIpAddress
		}

		public enum NumericComparisonType
		{
			NumericEquals,
			NumericGreaterThan,
			NumericGreaterThanEquals,
			NumericLessThan,
			NumericLessThanEquals,
			NumericNotEquals
		}

		public enum StringComparisonType
		{
			StringEquals,
			StringEqualsIgnoreCase,
			StringLike,
			StringNotEquals,
			StringNotEqualsIgnoreCase,
			StringNotLike
		}

		public const string CURRENT_TIME_CONDITION_KEY = "aws:CurrentTime";

		public const string SECURE_TRANSPORT_CONDITION_KEY = "aws:SecureTransport";

		public const string SOURCE_IP_CONDITION_KEY = "aws:SourceIp";

		public const string USER_AGENT_CONDITION_KEY = "aws:UserAgent";

		public const string EPOCH_TIME_CONDITION_KEY = "aws:EpochTime";

		public const string REFERRER_CONDITION_KEY = "aws:Referer";

		public const string SOURCE_ARN_CONDITION_KEY = "aws:SourceArn";

		public const string S3_CANNED_ACL_CONDITION_KEY = "s3:x-amz-acl";

		public const string S3_LOCATION_CONSTRAINT_CONDITION_KEY = "s3:LocationConstraint";

		public const string S3_PREFIX_CONDITION_KEY = "s3:prefix";

		public const string S3_DELIMITER_CONDITION_KEY = "s3:delimiter";

		public const string S3_MAX_KEYS_CONDITION_KEY = "s3:max-keys";

		public const string S3_COPY_SOURCE_CONDITION_KEY = "s3:x-amz-copy-source";

		public const string S3_METADATA_DIRECTIVE_CONDITION_KEY = "s3:x-amz-metadata-directive";

		public const string S3_VERSION_ID_CONDITION_KEY = "s3:VersionId";

		public const string SNS_ENDPOINT_CONDITION_KEY = "sns:Endpoint";

		public const string SNS_PROTOCOL_CONDITION_KEY = "sns:Protocol";

		public static Condition NewCondition(ArnComparisonType type, string key, string value)
		{
			return null;
		}

		public static Condition NewCondition(string key, bool value)
		{
			return null;
		}

		[Obsolete]
		public static Condition NewCondition(DateComparisonType type, DateTime date)
		{
			return null;
		}

		public static Condition NewConditionUtc(DateComparisonType type, DateTime date)
		{
			return null;
		}

		public static Condition NewIpAddressCondition(string ipAddressRange)
		{
			return null;
		}

		public static Condition NewCondition(IpAddressComparisonType type, string ipAddressRange)
		{
			return null;
		}

		public static Condition NewCondition(NumericComparisonType type, string key, string value)
		{
			return null;
		}

		public static Condition NewCondition(StringComparisonType type, string key, string value)
		{
			return null;
		}

		public static Condition NewSourceArnCondition(string arnPattern)
		{
			return null;
		}

		public static Condition NewSecureTransportCondition()
		{
			return null;
		}

		public static Condition NewCannedACLCondition(string cannedAcl)
		{
			return null;
		}

		public static Condition NewEndpointCondition(string endpointPattern)
		{
			return null;
		}

		public static Condition NewProtocolCondition(string protocol)
		{
			return null;
		}
	}
}
