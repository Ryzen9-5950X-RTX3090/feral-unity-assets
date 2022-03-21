namespace Amazon.Runtime.Internal.Transform
{
	public class ByteUnmarshaller : IUnmarshaller<byte, XmlUnmarshallerContext>, IUnmarshaller<byte, JsonUnmarshallerContext>
	{
		private static ByteUnmarshaller _instance;

		public static ByteUnmarshaller Instance
		{
			get
			{
				return null;
			}
		}

		private ByteUnmarshaller()
		{
		}

		public static ByteUnmarshaller GetInstance()
		{
			return null;
		}

		public byte Unmarshall(XmlUnmarshallerContext context)
		{
			return default(byte);
		}

		public byte Unmarshall(JsonUnmarshallerContext context)
		{
			return default(byte);
		}
	}
}
