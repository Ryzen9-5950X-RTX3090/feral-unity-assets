using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_MPUpdraftIndicator : MonoBehaviour
{
	[SerializeField]
	private RectTransform _mainRectTransform;

	[SerializeField]
	private GameObject _panelObject;

	[SerializeField]
	private RectTransform _panelRectTransform;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Transform _actionGroup;

	[SerializeField]
	private WWImage _actionIcon;

	private Vector3 _screenPosition;

	private Transform _targetTransform;

	private Vector3 _targetOffset;

	public static UI_MPUpdraftIndicator instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Setup()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	internal void ResetIndicator()
	{
	}

	private void Update()
	{
	}
}
