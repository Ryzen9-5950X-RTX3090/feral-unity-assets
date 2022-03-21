using UnityEngine;

public class UI_Control_ScaleGroupSlider : UI_CustomizationControl
{
	[SerializeField]
	private ConstrainedSlider _slider;

	[SerializeField]
	[RootSelector("Scale Group", "ActorScaleGroupChartData", false, false)]
	private string _scaleGroupId;

	private ActorInfoScaleGroup _scaleGroup;

	private bool _firstSetup;

	private ActorInfoScaleGroup ScaleGroup
	{
		get
		{
			return null;
		}
	}

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	private bool DesignMode
	{
		get
		{
			return default(bool);
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Reset()
	{
	}

	private void SliderValueChanged_Scale(float inScale)
	{
	}

	private void OnBodyPartSet(ActorInfoBodyPart inBodyPart)
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
