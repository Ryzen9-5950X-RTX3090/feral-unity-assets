using System.Runtime.CompilerServices;

namespace Amazon.Util
{
	public class AWSPublicIpAddressRange
	{
		public enum AddressFormat
		{
			Ipv4,
			Ipv6
		}

		public string IpPrefix
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public AddressFormat IpAddressFormat
		{
			[CompilerGenerated]
			get
			{
				return default(AddressFormat);
			}
			[CompilerGenerated]
			internal set
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
			internal set
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
			internal set
			{
			}
		}

		public string NetworkBorderGroup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
}
