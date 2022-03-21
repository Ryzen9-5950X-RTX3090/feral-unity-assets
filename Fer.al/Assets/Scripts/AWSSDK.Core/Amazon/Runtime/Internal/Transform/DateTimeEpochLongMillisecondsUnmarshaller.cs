using System;

namespace Amazon.Runtime.Internal.Transform
{
	public class DateTimeEpochLongMillisecondsUnmarshaller : IUnmarshaller<DateTime, XmlUnmarshallerContext>, IUnmarshaller<DateTime, JsonUnmarshallerContext>
	{
		private static DateTimeEpochLongMillisecondsUnmarshaller _instance;

		public static DateTimeEpochLongMillisecondsUnmarshaller Instance
		{
			get
			{
				return null;
			}
		}

		private DateTimeEpochLongMillisecondsUnmarshaller()
		{
		}

		public static DateTimeEpochLongMillisecondsUnmarshaller GetInstance()
		{
			return null;
		}

		public DateTime Unmarshall(XmlUnmarshallerContext context)
		{
			return default(DateTime);
		}

		public DateTime Unmarshall(JsonUnmarshallerContext context)
		{
			return default(DateTime);
		}
	}
}
