using System.Runtime.CompilerServices;

namespace Amazon
{
	public class Arn
	{
		private string _accountId;

		public string Partition
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

		public string Service
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

		public string Region
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

		public string AccountId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Resource
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

		public static bool IsArn(string arn)
		{
			return default(bool);
		}

		public static bool TryParse(string arnString, out Arn arn)
		{
			return default(bool);
		}

		public static Arn Parse(string arnString)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object o)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
