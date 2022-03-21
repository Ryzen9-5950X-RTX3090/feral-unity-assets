using System.Collections.Generic;
using UnityEngine;

namespace WW.Debug
{
	public class DebugLogRecycledListView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform transformComponent;

		[SerializeField]
		private RectTransform viewportTransform;

		[SerializeField]
		private DebugLogPanel _logPanel;

		[SerializeField]
		private Color logItemNormalColor1;

		[SerializeField]
		private Color logItemNormalColor2;

		[SerializeField]
		private Color logItemSelectedColor;

		private DebugPanel panel;

		private float logItemHeight;

		private float _1OverLogItemHeight;

		private float viewportHeight;

		private List<DebugLogEntry> collapsedLogEntries;

		private DebugLogIndexList indicesOfEntriesToShow;

		private int indexOfSelectedLogEntry;

		private float positionOfSelectedLogEntry;

		private float heightOfSelectedLogEntry;

		private float deltaHeightOfSelectedLogEntry;

		private Dictionary<int, DebugLogItem> logItemsAtIndices;

		private bool isCollapseOn;

		private int currentTopIndex;

		private int currentBottomIndex;

		public float ItemHeight
		{
			get
			{
				return default(float);
			}
		}

		public float SelectedItemHeight
		{
			get
			{
				return default(float);
			}
		}

		private void Awake()
		{
		}

		public void Initialize(DebugPanel panel, List<DebugLogEntry> collapsedLogEntries, DebugLogIndexList indicesOfEntriesToShow, float logItemHeight)
		{
		}

		public void SetCollapseMode(bool collapse)
		{
		}

		public void OnLogItemClicked(DebugLogItem item)
		{
		}

		public void DeselectSelectedLogItem()
		{
		}

		public void OnLogEntriesUpdated(bool updateAllVisibleItemContents)
		{
		}

		public void OnCollapsedLogEntryAtIndexUpdated(int index)
		{
		}

		public void OnViewportDimensionsChanged()
		{
		}

		private void HardResetItems()
		{
		}

		private void CalculateContentHeight()
		{
		}

		public void UpdateItemsInTheList(bool updateAllVisibleItemContents)
		{
		}

		private void CreateLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		private void CreateLogItemAtIndex(int index)
		{
		}

		private void DestroyLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		private void UpdateLogItemContentsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		private void ColorLogItem(DebugLogItem logItem, int index)
		{
		}
	}
}
