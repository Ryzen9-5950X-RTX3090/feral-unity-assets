using System.Runtime.InteropServices;

namespace VivoxUnity
{
	public sealed class ChannelId
	{
		private readonly string _domain;

		private readonly string _name;

		private readonly string _issuer;

		private readonly ChannelType _type;

		private readonly Channel3DProperties _properties;

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

		public ChannelType Type
		{
			get
			{
				return default(ChannelType);
			}
		}

		public Channel3DProperties Properties
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

		internal string GetUriDesignator(ChannelType value)
		{
			return null;
		}

		public ChannelId(string uri)
		{
		}

		public ChannelId(string issuer, string name, string domain, ChannelType type = ChannelType.NonPositional, [Optional] Channel3DProperties properties)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		private bool Equals(ChannelId other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool IsNullOrEmpty(ChannelId id)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		internal bool IsValid()
		{
			return default(bool);
		}

		internal bool IsValidName(string name)
		{
			return default(bool);
		}
	}
}
