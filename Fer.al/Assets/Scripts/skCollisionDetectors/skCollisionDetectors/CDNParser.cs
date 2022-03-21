using ProtoBuf;

namespace skCollisionDetectors
{
	[ProtoContract]
	public class CDNParser
	{
		[ProtoMember(1)]
		public static uint[] matrixA;

		[ProtoMember(2)]
		public static uint[] matrixB;

		public static string DeProcess(string inStr)
		{
			return null;
		}
	}
}
