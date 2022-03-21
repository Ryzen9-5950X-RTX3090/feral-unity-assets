using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_PartyMemberItem : MonoBehaviour
{
	[SerializeField]
	private GameObject _noUserGroup;

	[SerializeField]
	private GameObject _userGroup;

	[SerializeField]
	private WWTextMeshProUGUI _displayNameText;

	[SerializeField]
	private RawImage _iconImage;

	[SerializeField]
	private GameObject _partyLeaderGroup;

	[SerializeField]
	private Color _meColor;

	[SerializeField]
	private Color _notMeColor;

	private UserInfo _user;

	public UserInfo User
	{
		get
		{
			return null;
		}
	}

	public void Setup(UserInfo inUser, bool inIsPartyLeader)
	{
	}

	[IteratorStateMachine(typeof(<SetAvatarIcon>d__11))]
	private IEnumerator SetAvatarIcon()
	{
		return null;
	}
}
