using UnityEngine;

public class UI_Control_EyeSizeSlider : UI_CustomizationControl
{
	private enum EyeScaleType
	{
		Shape,
		Pupil
	}

	[SerializeField]
	private ConstrainedSlider _slider;

	[SerializeField]
	private EyeScaleType _scaleType;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private void OnEnable()
	{
	}

	private void Reset()
	{
	}

	private void SliderValueChanged_Scale(float inScale)
	{
	}

	public override bool CheckIsValid()
	{
		return default(bool);
	}

	public void Setup()
	{
	}
}
