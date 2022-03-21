using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugLogPanel : DebugPanel
	{
		[SerializeField]
		[Header("Visuals")]
		private DebugLogItem logItemPrefab;

		[SerializeField]
		[Header("Internal References")]
		private RectTransform logItemsContainer;

		[SerializeField]
		[Header("Properties")]
		private bool receiveLogcatLogsInAndroid;

		[SerializeField]
		private string logcatArguments;

		private bool screenDimensionsChanged;

		[SerializeField]
		[Header("Visuals")]
		private Sprite infoLog;

		[SerializeField]
		private Sprite warningLog;

		[SerializeField]
		private Sprite errorLog;

		private Dictionary<LogType, Sprite> logSpriteRepresentations;

		[SerializeField]
		private Color collapseButtonNormalColor;

		[SerializeField]
		private Color collapseButtonSelectedColor;

		[SerializeField]
		private Color filterButtonsNormalColor;

		[SerializeField]
		private Color filterButtonsSelectedColor;

		[SerializeField]
		[Header("Internal References")]
		private Image collapseButton;

		[SerializeField]
		private Image filterInfoButton;

		[SerializeField]
		private Image filterWarningButton;

		[SerializeField]
		private Image filterErrorButton;

		[SerializeField]
		private Text infoEntryCountText;

		[SerializeField]
		private Text warningEntryCountText;

		[SerializeField]
		private Text errorEntryCountText;

		[SerializeField]
		private DebugLogRecycledListView recycledListView;

		private DebugLogFilter logFilter;

		private List<DebugLogEntry> collapsedLogEntries;

		private Dictionary<DebugLogEntry, int> collapsedLogEntriesMap;

		private DebugLogIndexList uncollapsedLogEntriesIndices;

		private DebugLogIndexList indicesOfListEntriesToShow;

		private List<DebugLogItem> pooledLogItems;

		private int infoEntryCount;

		private int warningEntryCount;

		private int errorEntryCount;

		private string _searchString;

		private bool _searchHasResults;

		private bool isCollapseOn;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnConsoleShown()
		{
		}

		protected override void LateUpdate()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		private void OnSearchUpdated(string inText)
		{
		}

		private void ReceivedLog(string logString, string stackTrace, LogType logType)
		{
		}

		public override void BtnClicked_Clear()
		{
		}

		public void PoolLogItem(DebugLogItem logItem)
		{
		}

		public DebugLogItem PopLogItem()
		{
			return null;
		}

		public void CollapseButtonPressed()
		{
		}

		public void FilterLogButtonPressed()
		{
		}

		public void FilterWarningButtonPressed()
		{
		}

		public void FilterErrorButtonPressed()
		{
		}

		private void FilterLogs()
		{
		}
	}
}
