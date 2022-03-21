using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Esf
{
	public class SignaturePolicyId : Asn1Encodable
	{
		private readonly DerObjectIdentifier sigPolicyIdentifier;

		private readonly OtherHashAlgAndValue sigPolicyHash;

		private readonly Asn1Sequence sigPolicyQualifiers;

		public DerObjectIdentifier SigPolicyIdentifier
		{
			get
			{
				return null;
			}
		}

		public OtherHashAlgAndValue SigPolicyHash
		{
			get
			{
				return null;
			}
		}

		public static SignaturePolicyId GetInstance(object obj)
		{
			return null;
		}

		private SignaturePolicyId(Asn1Sequence seq)
		{
		}

		public SignaturePolicyId(DerObjectIdentifier sigPolicyIdentifier, OtherHashAlgAndValue sigPolicyHash)
		{
		}

		public SignaturePolicyId(DerObjectIdentifier sigPolicyIdentifier, OtherHashAlgAndValue sigPolicyHash, SigPolicyQualifierInfo[] sigPolicyQualifiers)
		{
		}

		public SignaturePolicyId(DerObjectIdentifier sigPolicyIdentifier, OtherHashAlgAndValue sigPolicyHash, IEnumerable sigPolicyQualifiers)
		{
		}

		public SigPolicyQualifierInfo[] GetSigPolicyQualifiers()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
