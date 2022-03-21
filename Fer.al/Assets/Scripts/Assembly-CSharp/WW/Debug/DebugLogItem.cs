using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugLogItem : MonoBehaviour
	{
		[SerializeField]
		private RectTransform transformComponent;

		[SerializeField]
		private Image imageComponent;

		[SerializeField]
		private Text logText;

		[SerializeField]
		private Image logTypeImage;

		[SerializeField]
		private GameObject logCountParent;

		[SerializeField]
		private Text logCountText;

		[SerializeField]
		private GameObject _copyBtn;

		private DebugLogEntry logEntry;

		private int entryIndex;

		private DebugLogRecycledListView manager;

		public RectTransform Transform
		{
			get
			{
				return null;
			}
		}

		public Image Image
		{
			get
			{
				return null;
			}
		}

		public int Index
		{
			get
			{
				return default(int);
			}
		}

		public void Initialize(DebugLogRecycledListView manager)
		{
		}

		public void SetContent(DebugLogEntry logEntry, int entryIndex, bool isExpanded)
		{
		}

		public void ShowCount()
		{
		}

		public void HideCount()
		{
		}

		public void Clicked()
		{
		}

		public void BtnClicked_CopyContent()
		{
		}

		public float CalculateExpandedHeight(string content)
		{
			return default(float);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
