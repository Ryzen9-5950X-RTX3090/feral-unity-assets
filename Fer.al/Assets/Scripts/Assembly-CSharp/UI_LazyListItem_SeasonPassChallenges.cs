using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_SeasonPassChallenges : UI_LazyListItem<ISeasonPassChallenge>
{
	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private WWTextMeshProUGUI _rewardText;

	[SerializeField]
	[Header("Progress")]
	private WWImage _progressImage;

	[SerializeField]
	private GameObject _groupComplete;

	[SerializeField]
	private WWTextMeshProUGUI _progressText;

	[SerializeField]
	private Color _progressColorIncomplete;

	[SerializeField]
	private Color _progressColorComplete;

	public override void Setup(Action<UI_LazyListItem<ISeasonPassChallenge>> inOnClicked, Action<UI_LazyListItem<ISeasonPassChallenge>> inOnSelected, ISeasonPassChallenge inData, UI_LazyItemList<ISeasonPassChallenge> inItemList)
	{
	}

	public override void Refresh()
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage)
	{
	}

	private void OnChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage)
	{
	}
}
