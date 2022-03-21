namespace Iss.Http
{
	internal interface IHttpProtocolCodec
	{
		string Encode(string sessionId, string message);

		string Decode(string message);
	}
}
