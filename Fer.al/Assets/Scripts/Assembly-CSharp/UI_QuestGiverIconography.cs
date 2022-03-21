using UnityEngine;
using UnityEngine.UI;

public class UI_QuestGiverIconography : MonoBehaviour
{
	[SerializeField]
	private float _maxDrawDistancee;

	private float _maxDrawDistanceSqr;

	[SerializeField]
	private GameObject _panelObject;

	[SerializeField]
	private RectTransform _panelRectTransform;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWImage _icon;

	private Vector3 _screenPosition;

	private Vector3 _targetOffset;

	private Transform _targetTransform;

	private bool _isInrange;

	private bool _wasInRange;

	private float _inRangeTimeDelay;

	private float _minDrawDistance;

	public void Setup(Transform inTargetTransform, Vector3 inIconOffset, float inMinDrawDistance, MinimapManager.EBlipType inBlipType)
	{
	}

	private void Start()
	{
	}

	internal void ResetIndicator()
	{
	}

	private void Update()
	{
	}

	private void ToggleView(bool inOn)
	{
	}
}
