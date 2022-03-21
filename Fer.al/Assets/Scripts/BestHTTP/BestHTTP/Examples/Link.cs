using UnityEngine;
using UnityEngine.EventSystems;

namespace BestHTTP.Examples
{
	public class Link : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
	{
		public string url;

		public Texture2D linkSelectCursor;

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
