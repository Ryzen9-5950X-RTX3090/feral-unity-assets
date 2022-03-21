using UnityEngine;

public class UI_Panel_SwitchCreature : MonoBehaviour
{
	[SerializeField]
	private UI_AvatarPositioner _avatarPositioner;

	[SerializeField]
	[RootSelector("CurrentLookText", "LocalizationChartData", false, false)]
	private string _currentLookLocalizationDefId;

	[SerializeField]
	[RootSelector("ChooseLookText", "LocalizationChartData", false, false)]
	private string _chooseLookLocalizationDefId;

	private string CurrentLookLocalizationText
	{
		get
		{
			return null;
		}
	}

	private string ChooseLookLocalizationText
	{
		get
		{
			return null;
		}
	}

	public void BtnClicked_SwitchCreatureLeft()
	{
	}

	public void BtnClicked_SwitchCreatureRight()
	{
	}

	private void RefreshChooseButtonText()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
