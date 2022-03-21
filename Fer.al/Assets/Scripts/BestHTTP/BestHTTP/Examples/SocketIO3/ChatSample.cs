using System;
using System.Collections.Generic;
using BestHTTP.Examples.Helpers;
using BestHTTP.SocketIO3;
using BestHTTP.SocketIO3.Events;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.SocketIO3
{
	public sealed class ChatSample : SampleBase
	{
		private readonly TimeSpan TYPING_TIMER_LENGTH;

		[SerializeField]
		[Tooltip("The Socket.IO service address to connect to")]
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

		public void UpdateTyping()
		{
		}

		public void OnMessageInput(string textToSend)
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

		private void OnConnected(ConnectResponse resp)
		{
		}

		private void OnDisconnected()
		{
		}

		private void OnLogin(LoginData data)
		{
		}

		private void OnNewMessage(NewMessageData data)
		{
		}

		private void OnUserJoined(UserJoinedData data)
		{
		}

		private void OnUserLeft(UserJoinedData data)
		{
		}

		private void OnTyping(TypingData data)
		{
		}

		private void OnStopTyping(TypingData data)
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
