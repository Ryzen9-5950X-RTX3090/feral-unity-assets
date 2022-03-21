namespace Amazon.Runtime.Internal.Transform
{
	public class DecimalUnmarshaller : IUnmarshaller<decimal, XmlUnmarshallerContext>, IUnmarshaller<decimal, JsonUnmarshallerContext>
	{
		private static DecimalUnmarshaller _instance;

		public static DecimalUnmarshaller Instance
		{
			get
			{
				return null;
			}
		}

		private DecimalUnmarshaller()
		{
		}

		public static DecimalUnmarshaller GetInstance()
		{
			return null;
		}

		public decimal Unmarshall(XmlUnmarshallerContext context)
		{
			return default(decimal);
		}

		public decimal Unmarshall(JsonUnmarshallerContext context)
		{
			return default(decimal);
		}
	}
}
