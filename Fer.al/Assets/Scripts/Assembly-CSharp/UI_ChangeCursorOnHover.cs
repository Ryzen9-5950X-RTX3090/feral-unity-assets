using UnityEngine;
using UnityEngine.EventSystems;

[ManagedBehaviourManager("CursorManager")]
public class UI_ChangeCursorOnHover : ManagedBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField]
	private CursorManager.MouseCursorType _cursorType;

	[SerializeField]
	private bool _maintainCursorWhileDragging;

	private bool _isHovered;

	private bool _isDragging;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MOnDisable()
	{
	}

	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
