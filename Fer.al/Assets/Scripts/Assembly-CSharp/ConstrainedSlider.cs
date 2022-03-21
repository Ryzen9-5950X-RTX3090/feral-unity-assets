using UnityEngine;
using UnityEngine.UI;

public class ConstrainedSlider : MonoBehaviour
{
	[SerializeField]
	private Slider _slider;

	[SerializeField]
	private RectTransform _blockerLeft;

	[SerializeField]
	private RectTransform _blockerRight;

	[SerializeField]
	private float _minValue;

	[SerializeField]
	private float _maxValue;

	[SerializeField]
	private float _availableMin;

	[SerializeField]
	private float _availableMax;

	private RectTransform _sliderRect;

	public Slider Slider
	{
		get
		{
			return null;
		}
	}

	private RectTransform SliderRect
	{
		get
		{
			return null;
		}
	}

	public void SetAvailableValues(float inMin, float inMax, float inAvailableMin, float inAvailableMax)
	{
	}

	private void UpdateVisuals()
	{
	}
}
