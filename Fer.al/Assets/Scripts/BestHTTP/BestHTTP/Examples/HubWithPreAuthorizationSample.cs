using BestHTTP.Examples.Helpers;
using BestHTTP.SignalRCore;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples
{
	public sealed class HubWithPreAuthorizationSample : SampleBase
	{
		[SerializeField]
		private string _hubPath;

		[SerializeField]
		private string _jwtTokenPath;

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

		private HubConnection hub;

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

		private void AuthenticationProvider_OnAuthenticationSucceded(IAuthenticationProvider provider)
		{
		}

		private void AuthenticationProvider_OnAuthenticationFailed(IAuthenticationProvider provider, string reason)
		{
		}

		private void Hub_OnConnected(HubConnection hub)
		{
		}

		private void Hub_OnClosed(HubConnection hub)
		{
		}

		private void Hub_OnError(HubConnection hub, string error)
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
