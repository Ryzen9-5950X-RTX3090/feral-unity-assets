using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class LazyLayoutVisibilityTest : MonoBehaviour
{
	[SerializeField]
	private LazyLayoutGroup _layoutGroup;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private FlowLazyLayoutGroup.Axis _maskingAxis;

	private void Start()
	{
	}

	private void OnScroll(Vector2 inScrollPosition)
	{
	}

	private void OnLayoutChanged()
	{
	}

	private void CalculateVisibility()
	{
	}
}
