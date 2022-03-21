namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
{
	public class DeclarationOfMajority : Asn1Encodable, IAsn1Choice
	{
		public enum Choice
		{
			NotYoungerThan,
			FullAgeAtCountry,
			DateOfBirth
		}

		private readonly Asn1TaggedObject declaration;

		public Choice Type
		{
			get
			{
				return default(Choice);
			}
		}

		public virtual int NotYoungerThan
		{
			get
			{
				return default(int);
			}
		}

		public virtual Asn1Sequence FullAgeAtCountry
		{
			get
			{
				return null;
			}
		}

		public virtual DerGeneralizedTime DateOfBirth
		{
			get
			{
				return null;
			}
		}

		public DeclarationOfMajority(int notYoungerThan)
		{
		}

		public DeclarationOfMajority(bool fullAge, string country)
		{
		}

		public DeclarationOfMajority(DerGeneralizedTime dateOfBirth)
		{
		}

		public static DeclarationOfMajority GetInstance(object obj)
		{
			return null;
		}

		private DeclarationOfMajority(Asn1TaggedObject o)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
