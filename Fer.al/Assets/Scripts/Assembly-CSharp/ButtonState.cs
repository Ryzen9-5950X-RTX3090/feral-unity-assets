using UnityEngine.EventSystems;

public class ButtonState : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	private bool _isPressed;

	private bool _isDown;

	private bool _isUp;

	public bool isPressed
	{
		get
		{
			return default(bool);
		}
	}

	public bool isDown
	{
		get
		{
			return default(bool);
		}
	}

	public bool isUp
	{
		get
		{
			return default(bool);
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
