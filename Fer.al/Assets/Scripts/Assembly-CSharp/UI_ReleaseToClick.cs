using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_ReleaseToClick : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Button _targetButton;

	private void Update()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
