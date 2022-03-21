namespace Iss.Http
{
	public class HttpConnection
	{
		public delegate void HttpCallbackHandler(HttpEvent evt);

		public const string HANDSHAKE_TOKEN = "#";

		private const string HANDSHAKE = "connect";

		private const string DISCONNECT = "disconnect";

		private const string CONN_LOST = "ERR#01";

		private const string servletUrl = "BlueBox/HttpBox.do";

		private const string paramName = "sfsHttp";

		private string sessionId;

		private bool connected;

		private string ipAddr;

		private int port;

		private string webUrl;

		private IHttpProtocolCodec codec;

		private IssClient sfs;

		private HttpCallbackHandler OnHttpConnectCallback;

		private HttpCallbackHandler OnHttpCloseCallback;

		private HttpCallbackHandler OnHttpErrorCallback;

		private HttpCallbackHandler OnHttpDataCallback;

		public HttpConnection(IssClient sfs)
		{
		}

		public string GetSessionId()
		{
			return null;
		}

		public bool IsConnected()
		{
			return default(bool);
		}

		public void Connect(string ipAddr)
		{
		}

		public void Connect(string ipAddr, int port)
		{
		}

		public string GetWebUrl()
		{
			return null;
		}

		public void Close()
		{
		}

		public void Send(string message)
		{
		}

		private void HttpSendViaSockets(string message)
		{
		}

		public void AddEventListener(string evt, HttpCallbackHandler method)
		{
		}
	}
}
