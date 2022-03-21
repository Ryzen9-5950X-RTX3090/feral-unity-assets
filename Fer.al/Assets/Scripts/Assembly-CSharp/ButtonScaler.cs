using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScaler : ManagedBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	private float _targetScale;

	[SerializeField]
	private float _tweenTime;

	[SerializeField]
	[Tooltip("Leave null for to make target self")]
	private Transform _target;

	[SerializeField]
	[Tooltip("Ex: the button component. Used to ignore events when not interactable")]
	private Selectable _selectable;

	private float _defaultScale;

	public override void Awake()
	{
	}

	public override void MOnEnable()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void OnApplicationFocus(bool inIsFocused)
	{
	}
}
