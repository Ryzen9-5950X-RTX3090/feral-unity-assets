using System;

namespace ProtoBuf
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ProtoMemberAttribute : Attribute, IComparable, IComparable<ProtoMemberAttribute>
	{
		private string name;

		private int tag;

		public int CompareTo(object other)
		{
			return default(int);
		}

		public int CompareTo(ProtoMemberAttribute other)
		{
			return default(int);
		}

		public ProtoMemberAttribute(int tag)
		{
		}

		internal ProtoMemberAttribute(int tag, bool forced)
		{
		}
	}
}
