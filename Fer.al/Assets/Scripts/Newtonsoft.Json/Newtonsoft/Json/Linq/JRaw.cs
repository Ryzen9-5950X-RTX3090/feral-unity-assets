namespace Newtonsoft.Json.Linq
{
	public class JRaw : JValue
	{
		public JRaw(JRaw other)
		{
		}

		public JRaw(object rawJson)
		{
		}

		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		internal override JToken CloneToken()
		{
			return null;
		}
	}
}
