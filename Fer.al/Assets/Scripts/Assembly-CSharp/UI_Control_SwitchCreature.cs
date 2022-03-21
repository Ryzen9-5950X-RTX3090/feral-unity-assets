using UnityEngine;

public class UI_Control_SwitchCreature : UI_CustomizationControl
{
	[SerializeField]
	private GameObject _pageFrameBg;

	[SerializeField]
	private GameObject _externalPageGroup;

	private UI_CustomizationPageBody _pageBody;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override bool CheckIsValid()
	{
		return default(bool);
	}
}
