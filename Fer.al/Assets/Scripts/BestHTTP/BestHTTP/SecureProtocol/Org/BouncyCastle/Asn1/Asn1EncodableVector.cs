using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class Asn1EncodableVector : IEnumerable
	{
		internal static readonly Asn1Encodable[] EmptyElements;

		private const int DefaultCapacity = 10;

		private Asn1Encodable[] elements;

		private int elementCount;

		private bool copyOnWrite;

		public Asn1Encodable this[int index]
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public static Asn1EncodableVector FromEnumerable(IEnumerable e)
		{
			return null;
		}

		public Asn1EncodableVector()
		{
		}

		public Asn1EncodableVector(int initialCapacity)
		{
		}

		public Asn1EncodableVector(Asn1Encodable[] v)
		{
		}

		public void Add(Asn1Encodable element)
		{
		}

		public void Add(Asn1Encodable[] objs)
		{
		}

		public void AddOptional(Asn1Encodable[] objs)
		{
		}

		public void AddOptionalTagged(bool isExplicit, int tagNo, Asn1Encodable obj)
		{
		}

		public void AddAll(Asn1EncodableVector other)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		internal Asn1Encodable[] CopyElements()
		{
			return null;
		}

		internal Asn1Encodable[] TakeElements()
		{
			return null;
		}

		private void Reallocate(int minCapacity)
		{
		}

		internal static Asn1Encodable[] CloneElements(Asn1Encodable[] elements)
		{
			return null;
		}
	}
}
