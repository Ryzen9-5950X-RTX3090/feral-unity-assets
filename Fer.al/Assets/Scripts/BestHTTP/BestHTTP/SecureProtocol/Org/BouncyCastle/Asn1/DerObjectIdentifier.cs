using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class DerObjectIdentifier : Asn1Object
	{
		private readonly string identifier;

		private byte[] body;

		private const long LONG_LIMIT = 72057594037927808L;

		private static readonly DerObjectIdentifier[] cache;

		public string Id
		{
			get
			{
				return null;
			}
		}

		public static DerObjectIdentifier GetInstance(object obj)
		{
			return null;
		}

		public static DerObjectIdentifier GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public DerObjectIdentifier(string identifier)
		{
		}

		internal DerObjectIdentifier(DerObjectIdentifier oid, string branchID)
		{
		}

		public virtual DerObjectIdentifier Branch(string branchID)
		{
			return null;
		}

		public virtual bool On(DerObjectIdentifier stem)
		{
			return default(bool);
		}

		internal DerObjectIdentifier(byte[] bytes)
		{
		}

		private void WriteField(Stream outputStream, long fieldValue)
		{
		}

		private void WriteField(Stream outputStream, BigInteger fieldValue)
		{
		}

		private void DoOutput(MemoryStream bOut)
		{
		}

		internal byte[] GetBody()
		{
			return null;
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}

		protected override int Asn1GetHashCode()
		{
			return default(int);
		}

		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		private static bool IsValidBranchID(string branchID, int start)
		{
			return default(bool);
		}

		private static bool IsValidIdentifier(string identifier)
		{
			return default(bool);
		}

		private static string MakeOidStringFromBytes(byte[] bytes)
		{
			return null;
		}

		internal static DerObjectIdentifier FromOctetString(byte[] enc)
		{
			return null;
		}
	}
}
