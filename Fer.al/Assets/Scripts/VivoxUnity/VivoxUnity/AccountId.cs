using System.Runtime.InteropServices;

namespace VivoxUnity
{
	public sealed class AccountId
	{
		public const int _accountNameMaxLength = 127;

		private readonly string _domain;

		private readonly string _name;

		private readonly string _issuer;

		private readonly string _displayname;

		private readonly string[] _spokenLanguages;

		public string Issuer
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Domain
		{
			get
			{
				return null;
			}
		}

		public string[] SpokenLanguages
		{
			get
			{
				return null;
			}
		}

		internal string AccountName
		{
			get
			{
				return null;
			}
		}

		public string DisplayName
		{
			get
			{
				return null;
			}
		}

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public AccountId(string uri, [Optional] string displayname)
		{
		}

		public AccountId(string issuer, string name, string domain, [Optional] string displayname, [Optional] string[] spokenLanguages)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		private bool Equals(AccountId other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool IsNullOrEmpty(AccountId id)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		internal bool IsValidName(string name)
		{
			return default(bool);
		}
	}
}
