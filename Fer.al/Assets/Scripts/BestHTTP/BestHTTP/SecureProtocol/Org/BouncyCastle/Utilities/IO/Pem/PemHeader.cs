namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
	public class PemHeader
	{
		private string name;

		private string val;

		public virtual string Name
		{
			get
			{
				return null;
			}
		}

		public virtual string Value
		{
			get
			{
				return null;
			}
		}

		public PemHeader(string name, string val)
		{
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		private int GetHashCode(string s)
		{
			return default(int);
		}
	}
}
