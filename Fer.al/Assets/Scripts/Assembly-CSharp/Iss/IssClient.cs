using System;
using System.Collections;
using System.Text;
using Iss.Handlers;
using Iss.Http;

namespace Iss
{
	public class IssClient : WWTcpClient
	{
		public enum XtMsgType
		{
			Xml,
			Csv,
			Json
		}

		private const int EOM = 0;

		private static readonly char MSG_XML;

		private static readonly char MSG_JSON;

		private static readonly char MSG_STR;

		private static readonly string MSG_TYPE_XT;

		private static readonly char OPT_NO_RESET;

		private static readonly char OPT_DELIMITER;

		private static readonly string TYPE_XT_NO_RESET;

		private const int MIN_POLL_SPEED = 0;

		private const int DEFAULT_POLL_SPEED = 750;

		private const int MAX_POLL_SPEED = 10000;

		private const string HTTP_POLL_REQUEST = "poll";

		public const string CONNECTION_MODE_DISCONNECTED = "disconnected";

		public const string CONNECTION_MODE_SOCKET = "socket";

		public const string CONNECTION_MODE_HTTP = "http";

		private bool isHttpMode;

		private int _httpPollSpeed;

		private HttpConnection httpConnection;

		private SysHandler sysHandler;

		private ExtHandler extHandler;

		public IssEvent.OnAdminMessageDelegate onAdminMessage;

		public IssEvent.OnExtensionResponseDelegate onExtensionResponse;

		public IssEvent.OnJoinRoomDelegate onJoinRoom;

		public IssEvent.OnJoinRoomErrorDelegate onJoinRoomError;

		public IssEvent.OnLoginDelegate onLogin;

		public IssEvent.OnLogoutDelegate onLogout;

		public IssEvent.OnRandomKeyDelegate onRandomKey;

		public IssEvent.OnRoomListUpdateDelegate onRoomListUpdate;

		public string defaultZone;

		public string blueBoxIpAddress;

		public int blueBoxPort;

		public bool smartConnect;

		public bool checkVersion;

		public int myUserId;

		public string myUsername;

		public int playerId;

		public int activeRoomId;

		public bool changingRoom;

		public int httpPort;

		private readonly string _xtInitalCommand;

		private readonly string _xtInitialCommandNoReset;

		private StringBuilder _xtBuffer;

		public bool IsConnected
		{
			get
			{
				return default(bool);
			}
		}

		public int HttpPollSpeed
		{
			get
			{
				return default(int);
			}
		}

		public string ConnectionMode
		{
			get
			{
				return null;
			}
		}

		public void SetIsConnected(bool b)
		{
		}

		public void SetHttpPollSpeed(int sp)
		{
		}

		public IssClient()
		{
		}

		public IssClient(bool debug, bool useSecure)
		{
		}

		~IssClient()
		{
		}

		public override void Disconnect()
		{
		}

		public void Login(string zone, string name, string pass)
		{
		}

		public void Logout()
		{
		}

		public void SendPublicMessage(string message)
		{
		}

		public void SendPublicMessage(string message, int roomId)
		{
		}

		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, bool noReset)
		{
		}

		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, XtMsgType type, bool noReset)
		{
		}

		public void SendXtMessageCompressed(string xtName, string cmd, ICollection paramObj, bool noReset)
		{
		}

		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, XtMsgType type, int roomId, bool compress, bool noReset)
		{
		}

		public void GetRandomKey()
		{
		}

		protected override void Initialize(bool isLogOut)
		{
		}

		private void SetupMessageHandlers()
		{
		}

		private void AddMessageHandler(string key, IMessageHandler handler)
		{
		}

		protected override void HandleMessage(string msg)
		{
		}

		private void XmlReceived(string msg)
		{
		}

		private void JsonReceived(string msg)
		{
		}

		private void StrReceived(string msg)
		{
		}

		private void Send(Hashtable header, string action, int fromRoom, string message)
		{
		}

		private string MakeXmlHeader(Hashtable headerObj)
		{
			return null;
		}

		private string CloseXmlHeader()
		{
			return null;
		}

		protected override void SendString(string strMessage, bool log)
		{
		}

		internal void SendJson(string jsMessage)
		{
		}

		protected override void HandleSocketConnection(object sender, EventArgs e)
		{
		}

		protected override void HandleSocketDisconnection()
		{
		}

		protected override void HandleIOError(string originalError)
		{
		}

		private void TryBlueBoxConnection(string originalError)
		{
		}

		private void StartHttpPollThread()
		{
		}

		private void HttpPoll()
		{
		}

		private void HandleHttpData(HttpEvent evt)
		{
		}

		private void HandleHttpConnect(HttpEvent evt)
		{
		}

		private void HandleHttpClose(HttpEvent evt)
		{
		}

		private void HandleHttpError(HttpEvent evt)
		{
		}

		protected override void _DispatchEvent(WWTcpEvent evt)
		{
		}
	}
}
