namespace Iss.Http
{
	public class RawProtocolCodec : IHttpProtocolCodec
	{
		private const int SESSION_ID_LEN = 32;

		public string Encode(string sessionId, string message)
		{
			return null;
		}

		public string Decode(string message)
		{
			return null;
		}
	}
}
