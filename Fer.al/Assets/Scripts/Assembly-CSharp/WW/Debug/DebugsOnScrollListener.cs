using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugsOnScrollListener : MonoBehaviour, IScrollHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		public ScrollRect debugsScrollRect;

		public DebugPanel debugPanel;

		public void OnScroll(PointerEventData data)
		{
		}

		public void OnBeginDrag(PointerEventData data)
		{
		}

		public void OnEndDrag(PointerEventData data)
		{
		}

		public void OnScrollbarDragStart(BaseEventData data)
		{
		}

		public void OnScrollbarDragEnd(BaseEventData data)
		{
		}

		private bool IsScrollbarAtBottom()
		{
			return default(bool);
		}
	}
}
