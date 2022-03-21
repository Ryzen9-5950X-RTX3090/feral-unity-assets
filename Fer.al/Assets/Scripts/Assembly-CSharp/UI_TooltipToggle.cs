using UnityEngine;
using UnityEngine.UI;

public class UI_TooltipToggle : UI_Tooltip
{
	[SerializeField]
	[RootSelector("On Text", "LocalizationChartData", false, false)]
	private string _localizationDefIdOn;

	[SerializeField]
	[RootSelector("Off Text", "LocalizationChartData", false, false)]
	private string _localizationDefIdOff;

	[SerializeField]
	private FeralButton _button;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	protected override void Reset()
	{
	}

	private void OnButtonToggled(bool inIsOn)
	{
	}
}
