using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_QuestSummary : MonoBehaviour
{
	[SerializeField]
	private Color _completeColor;

	[SerializeField]
	private Color _incompleteColor;

	[SerializeField]
	private WWTextMeshProUGUI _sideQuestsText;

	[SerializeField]
	private GameObject _sideQuestsGroup;

	[SerializeField]
	private WWTextMeshProUGUI _cindersDefeatedText;

	[SerializeField]
	private GameObject _cindersDefeatedGroup;

	[SerializeField]
	private WWTextMeshProUGUI _secretsFoundText;

	[SerializeField]
	private GameObject _secretsFoundGroup;

	[SerializeField]
	private WWTextMeshProUGUI _treasuresFoundText;

	[SerializeField]
	private GameObject _treasuresFoundGroup;

	[SerializeField]
	private WWTextMeshProUGUI _puzzlesSolvedText;

	[SerializeField]
	private GameObject _puzzlesSolvedGroup;

	[SerializeField]
	[Header("Progress")]
	private WWImage _progressImage;

	[SerializeField]
	private Slider _progressSlider;

	[SerializeField]
	private WWTextMeshProUGUI _progressText;

	[SerializeField]
	private CanvasGroup _fullCompletionGroup;

	[SerializeField]
	private Selectable _fullCompletionSelectable;

	private QuestSummary _summary;

	private Func<bool> _questIsCompleteFunc;

	public WWImage ProgessImage
	{
		get
		{
			return null;
		}
	}

	public WWTextMeshProUGUI ProgressText
	{
		get
		{
			return null;
		}
	}

	private bool QuestIsComplete
	{
		get
		{
			return default(bool);
		}
	}

	public void Setup(QuestSummary inSummary, [Optional] Func<bool> inQuestIsComplete)
	{
	}

	private void Refresh()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnQuestSummaryUpdated(QuestSummaryUpdatedMessage inMessage)
	{
	}

	private void SetSideQuestsProgress(int inCurrent, int inTotal)
	{
	}

	private void SetCindersDefeatedProgress(int inCurrent, int inTotal)
	{
	}

	private void SetSecretsFoundProgress(int inCurrent, int inTotal)
	{
	}

	private void SetTreasuresFoundProgress(int inCurrent, int inTotal)
	{
	}

	private void SetPuzzlesSolvedProgress(int inCurrent, int inTotal)
	{
	}

	private void RefreshCompletion()
	{
	}
}
