using System;
using System.Collections.Generic;
using BestHTTP.Examples.Helpers;
using BestHTTP.SocketIO;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples
{
	public sealed class SocketIOChatSample : SampleBase
	{
		private readonly TimeSpan TYPING_TIMER_LENGTH;

		[SerializeField]
		[Tooltip("The WebSocket address to connect")]
		private string address;

		[SerializeField]
		[Header("Login Details")]
		private RectTransform _loginRoot;

		[SerializeField]
		private InputField _userNameInput;

		[SerializeField]
		[Header("Chat Setup")]
		private RectTransform _chatRoot;

		[SerializeField]
		private Text _participantsText;

		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private RectTransform _contentRoot;

		[SerializeField]
		private TextListItem _listItemPrefab;

		[SerializeField]
		private int _maxListItemEntries;

		[SerializeField]
		private Text _typingUsersText;

		[SerializeField]
		private InputField _input;

		[SerializeField]
		[Header("Buttons")]
		private Button _connectButton;

		[SerializeField]
		private Button _closeButton;

		private SocketManager Manager;

		private bool typing;

		private DateTime lastTypingTime;

		private List<string> typingUsers;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnUserNameInputChanged(string userName)
		{
		}

		public void OnUserNameInputSubmit(string userName)
		{
		}

		public void OnConnectButton()
		{
		}

		public void OnCloseButton()
		{
		}

		private void Update()
		{
		}

		public void OnMessageInput(string textToSend)
		{
		}

		public void UpdateTyping(string textToSend)
		{
		}

		private void addParticipantsMessage(Dictionary<string, object> data)
		{
		}

		private void addChatMessage(Dictionary<string, object> data)
		{
		}

		private void AddChatTyping(Dictionary<string, object> data)
		{
		}

		private void RemoveChatTyping(Dictionary<string, object> data)
		{
		}

		private void OnLogin(Socket socket, Packet packet, object[] args)
		{
		}

		private void OnNewMessage(Socket socket, Packet packet, object[] args)
		{
		}

		private void OnUserJoined(Socket socket, Packet packet, object[] args)
		{
		}

		private void OnUserLeft(Socket socket, Packet packet, object[] args)
		{
		}

		private void OnTyping(Socket socket, Packet packet, object[] args)
		{
		}

		private void OnStopTyping(Socket socket, Packet packet, object[] args)
		{
		}

		private void AddText(string text)
		{
		}

		private void SetTypingUsers()
		{
		}

		private void SetPanels(bool login)
		{
		}

		private void SetButtons(bool connect, bool close)
		{
		}
	}
}
