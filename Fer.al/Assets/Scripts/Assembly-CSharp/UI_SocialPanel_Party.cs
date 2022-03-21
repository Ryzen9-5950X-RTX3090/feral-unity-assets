using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SocialPanel_Party : MonoBehaviour
{
	[SerializeField]
	private GameObject _noPartyGroup;

	[SerializeField]
	private GameObject _partyGroup;

	[SerializeField]
	private List<UI_PartyMemberItem> _partyMemberItems;

	[SerializeField]
	private FeralButton _startQuestButton;

	private int _partySize;

	public void BtnClicked_LeaveParty()
	{
	}

	public void BtnClicked_StartQuest()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void RefreshHasParty()
	{
	}

	private void OnPartyCreated(RequestGroupTeamCreateSuccessMessage inMessage)
	{
	}

	private void OnUserLeave(GroupTeamUserLeftMessage inMessage)
	{
	}

	private void OnUserJoin(GroupTeamUserJoinedMessage inMessage)
	{
	}

	private void OnPartyDisbanded(GroupTeamLeaveMessage inMessage)
	{
	}
}
