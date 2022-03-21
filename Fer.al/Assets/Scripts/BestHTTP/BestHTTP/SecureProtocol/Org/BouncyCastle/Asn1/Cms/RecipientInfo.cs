namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class RecipientInfo : Asn1Encodable, IAsn1Choice
	{
		internal Asn1Encodable info;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public bool IsTagged
		{
			get
			{
				return default(bool);
			}
		}

		public Asn1Encodable Info
		{
			get
			{
				return null;
			}
		}

		public RecipientInfo(KeyTransRecipientInfo info)
		{
		}

		public RecipientInfo(KeyAgreeRecipientInfo info)
		{
		}

		public RecipientInfo(KekRecipientInfo info)
		{
		}

		public RecipientInfo(PasswordRecipientInfo info)
		{
		}

		public RecipientInfo(OtherRecipientInfo info)
		{
		}

		public RecipientInfo(Asn1Object info)
		{
		}

		public static RecipientInfo GetInstance(object o)
		{
			return null;
		}

		private KekRecipientInfo GetKekInfo(Asn1TaggedObject o)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
