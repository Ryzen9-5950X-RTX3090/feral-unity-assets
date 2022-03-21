using UnityEngine;
using UnityEngine.UI;

public class WWSmoothLayoutSizeApplier : MonoBehaviour
{
	[SerializeField]
	private bool _applyVertical;

	[SerializeField]
	private bool _applyHorizontal;

	[SerializeField]
	[Tooltip("Optional if you don't want to use a content size fitter")]
	private GameObject _srcLayoutElementObject;

	private ILayoutElement _srcLayoutElement;

	private LayoutElement _targetLayoutElement;

	private bool _isSetup;

	private WWSmoothLayout _smoothLayout;

	private RectTransform _rectTransform;

	public void Setup(LayoutElement inChangeTarget, WWSmoothLayout inSmoothLayout)
	{
	}

	private void Update()
	{
	}

	private void OnRectTransformDimensionsChange()
	{
	}

	private void Reset()
	{
	}
}
