using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rectangle))]
public class UI_CornerNoise : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public enum PlayMode
	{
		OnEnable = 0,
		OnPointerEnter = 5,
		Manual = 10
	}

	[SerializeField]
	private Rectangle _rectangle;

	[SerializeField]
	private Vector2 _moveScale;

	[SerializeField]
	private float _speedScale;

	[SerializeField]
	private PlayMode _playMode;

	private Vector2 _currentMoveScale;

	private Vector2 _cornerAStart;

	private Vector2 _cornerBStart;

	private Vector2 _cornerCStart;

	private Vector2 _cornerDStart;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void BeginNoise(float inTransitionTime = 0.25f)
	{
	}

	public void EndNoise(float inTransitionTime = 0.25f)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void Reset()
	{
	}
}
