using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UI_OnSelected : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	public UnityEvent onSelectedEvent;

	public UnityEvent onDeselectedEvent;

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}
}
