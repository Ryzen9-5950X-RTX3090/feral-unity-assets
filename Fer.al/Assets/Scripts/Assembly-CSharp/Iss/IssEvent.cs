using System.Collections;
using Iss.Data;

namespace Iss
{
	public class IssEvent : WWTcpEvent
	{
		public delegate void OnAdminMessageDelegate(string message);

		public delegate void OnExtensionResponseDelegate(object dataObj, IssClient.XtMsgType type);

		public delegate void OnJoinRoomDelegate(Room room);

		public delegate void OnJoinRoomErrorDelegate(string error);

		public delegate void OnLoginDelegate(bool success, string name, string error);

		public delegate void OnLogoutDelegate();

		public delegate void OnRandomKeyDelegate(string key);

		public delegate void OnRoomListUpdateDelegate(Hashtable roomList);

		internal const string onExtensionResponseEvent = "OnExtensionResponse";

		internal const string onLoginEvent = "OnLogin";

		internal const string onLogoutEvent = "OnLogout";

		internal const string onObjectReceivedEvent = "OnObjectReceived";

		internal const string onPublicMessageEvent = "OnPublicMessage";

		internal const string onRandomKeyEvent = "OnRandomKey";

		internal const string onRoomListUpdateEvent = "OnRoomListUpdate";

		public IssEvent(string type, Hashtable parameters)
		{
		}
	}
}
