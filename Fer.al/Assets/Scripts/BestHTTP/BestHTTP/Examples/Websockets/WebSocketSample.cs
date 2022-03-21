using BestHTTP.Examples.Helpers;
using BestHTTP.WebSocket;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.Websockets
{
	public class WebSocketSample : SampleBase
	{
		[SerializeField]
		[Tooltip("The WebSocket address to connect")]
		private string address;

		[SerializeField]
		private InputField _input;

		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private RectTransform _contentRoot;

		[SerializeField]
		private TextListItem _listItemPrefab;

		[SerializeField]
		private int _maxListItemEntries;

		[SerializeField]
		private Button _connectButton;

		[SerializeField]
		private Button _closeButton;

		private BestHTTP.WebSocket.WebSocket webSocket;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnConnectButton()
		{
		}

		public void OnCloseButton()
		{
		}

		public void OnInputField(string textToSend)
		{
		}

		private void OnOpen(BestHTTP.WebSocket.WebSocket ws)
		{
		}

		private void OnMessageReceived(BestHTTP.WebSocket.WebSocket ws, string message)
		{
		}

		private void OnClosed(BestHTTP.WebSocket.WebSocket ws, ushort code, string message)
		{
		}

		private void OnError(BestHTTP.WebSocket.WebSocket ws, string error)
		{
		}

		private void SetButtons(bool connect, bool close)
		{
		}

		private TextListItem AddText(string text)
		{
			return null;
		}
	}
}
