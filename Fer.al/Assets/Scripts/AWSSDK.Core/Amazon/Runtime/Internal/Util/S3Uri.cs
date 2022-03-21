using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal.Util
{
	public class S3Uri
	{
		private const string S3EndpointPattern = "^(.+\\.)?s3[.-]([a-z0-9-]+)\\.";

		private const string S3ControlExlusionPattern = "^(.+\\.)?s3-control\\.";

		private static readonly Regex S3EndpointRegex;

		private static readonly Regex S3ControlExlusionRegex;

		public bool IsPathStyle
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Bucket
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RegionEndpoint Region
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public S3Uri(string uri)
		{
		}

		public S3Uri(Uri uri)
		{
		}

		public static bool IsS3Uri(Uri uri)
		{
			return default(bool);
		}

		private static string Decode(string s)
		{
			return null;
		}

		private static string Decode(string s, int firstPercent)
		{
			return null;
		}

		private static void AppendDecoded(StringBuilder builder, string s, int index)
		{
		}

		private static int FromHex(char c)
		{
			return default(int);
		}
	}
}
