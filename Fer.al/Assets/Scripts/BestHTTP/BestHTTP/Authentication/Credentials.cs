using System.Runtime.CompilerServices;

namespace BestHTTP.Authentication
{
	public sealed class Credentials
	{
		public AuthenticationTypes Type
		{
			[CompilerGenerated]
			get
			{
				return default(AuthenticationTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string UserName
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

		public string Password
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

		public Credentials(string userName, string password)
		{
		}

		public Credentials(AuthenticationTypes type, string userName, string password)
		{
		}
	}
}
