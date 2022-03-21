using BestHTTP.Examples.Helpers;
using BestHTTP.ServerSentEvents;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.ServerSentEvents
{
	public class SimpleSample : SampleBase
	{
		[SerializeField]
		[Tooltip("The url of the resource to use.")]
		private string _path;

		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private RectTransform _contentRoot;

		[SerializeField]
		private TextListItem _listItemPrefab;

		[SerializeField]
		private int _maxListItemEntries;

		[SerializeField]
		private Button _startButton;

		[SerializeField]
		private Button _closeButton;

		private EventSource eventSource;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnStartButton()
		{
		}

		public void OnCloseButton()
		{
		}

		private void OnOpen(EventSource eventSource)
		{
		}

		private void OnClosed(EventSource eventSource)
		{
		}

		private void OnError(EventSource eventSource, string error)
		{
		}

		private void OnStateChanged(EventSource eventSource, States oldState, States newState)
		{
		}

		private void OnMessage(EventSource eventSource, Message message)
		{
		}

		private void OnDateTime(EventSource eventSource, Message message)
		{
		}

		private void SetButtons(bool start, bool close)
		{
		}

		private void AddText(string text)
		{
		}
	}
}
