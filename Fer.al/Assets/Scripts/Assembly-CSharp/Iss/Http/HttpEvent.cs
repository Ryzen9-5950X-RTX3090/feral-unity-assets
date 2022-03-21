using System.Collections;

namespace Iss.Http
{
	public class HttpEvent
	{
		public const string onHttpData = "OnHttpData";

		public const string onHttpError = "OnHttpError";

		public const string onHttpConnect = "OnHttpConnect";

		public const string onHttpClose = "OnHttpClose";

		private string type;

		private Hashtable parameters;

		public HttpEvent(string type, Hashtable parameters)
		{
		}

		public new string GetType()
		{
			return null;
		}

		public object GetParameter(string key)
		{
			return null;
		}
	}
}
