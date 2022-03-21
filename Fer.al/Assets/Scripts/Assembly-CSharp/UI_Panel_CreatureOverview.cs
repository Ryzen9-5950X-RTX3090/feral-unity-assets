using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Panel_CreatureOverview : UI_Panel
{
	[SerializeField]
	private UI_AvatarPositioner _avatarPositioner;

	[SerializeField]
	private FeralButton _visibilityToggle;

	[SerializeField]
	private GameObject _textBox;

	[SerializeField]
	private CanvasGroup _charmLocations;

	[SerializeField]
	private bool _useAvgForCalloutAngles;

	[SerializeField]
	private bool _usePresetAngles;

	[SerializeField]
	private List<UI_CharmSlotCallout> _charmSlotCallouts;

	[SerializeField]
	private WWSmoothLayout _smoothLayout;

	[SerializeField]
	private List<UI_CharmList> _charmLists;

	[SerializeField]
	private FeralAudioInfo _charmClickedSound;

	[SerializeField]
	private FeralAudioInfo _charmSlotClickedSound;

	private RectTransform _charmLocationsRectTransform;

	private UI_Stage_Avatar _avatarStage;

	private Camera _uiCamera;

	private RectTransform CharmLocationsRectTransform
	{
		get
		{
			return null;
		}
	}

	public UI_Stage_Avatar AvatarStage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	public override void MUpdate()
	{
	}

	public void BtnClicked_ViewCharmLocationsToggle(bool inIsOn)
	{
	}

	public void CharmClicked(UI_CharmList inCharmList, UI_CharmItem inCharmItem)
	{
	}

	private void SetupCharmSlotCallouts()
	{
	}

	private void UpdateCharmSlotCallouts()
	{
	}
}
